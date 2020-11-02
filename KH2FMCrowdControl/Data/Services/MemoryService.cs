using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public class MemoryService
    {
        public static event TimerDelegate OnTimerChanged;

        // Key: Host Name - Key: Category Name - Value: Buttons
        public static Dictionary<string, Dictionary<GroupType, List<ButtonTemplate>>> Options;
        public Dictionary<string, Dictionary<int, int>> OptionCooldowns;

        // Key: Host Name - Value: Point updates
        public Dictionary<string, int> Points = new Dictionary<string, int>();
        public Dictionary<string, Dictionary<string, Timer>> CooldownTimers = new Dictionary<string, Dictionary<string, Timer>>();

        public static event AlertDelegate OnAlertReceived;

        public readonly Options OptionsClass;

        public static void SendAlert(object sender, AlertArgs e)
        {
            OnAlertReceived?.Invoke(sender, e);
        }

        public MemoryService(IHubContext<MessageHub> context)
        {
            OptionsClass = new Options(context);

            Options = new Dictionary<string, Dictionary<GroupType, List<ButtonTemplate>>>();
            this.OptionCooldowns = new Dictionary<string, Dictionary<int, int>>();
        }

        #region Option Instantiation and Update Option/ Cost/Cooldown

        public async Task InitializeOptions(string hostName)
        {
            if (!Options.ContainsKey(hostName))
                Options.Add(hostName, await OptionsClass.InitializeOptions());

            if (!this.OptionCooldowns.ContainsKey(hostName))
                this.OptionCooldowns.Add(hostName, Constants.Cooldowns.ToDictionary(x => x.Key, x => x.Value));
        }

        public async Task UpdateOption(string hostName, GroupType category, string optionName, string subOptionName, int cost)
        {
            if (Options.ContainsKey(hostName) && Options[hostName].ContainsKey(category))
            {
                if (!string.IsNullOrEmpty(subOptionName))
                    Options[hostName][category].FirstOrDefault(x => x.Name == optionName).SubMethodParams.FirstOrDefault(x => x.Name == subOptionName).Cost = cost;
                else
                    Options[hostName][category].FirstOrDefault(x => x.Name == optionName).Cost = cost;
            }
        }

        public async Task UpdateOption(string hostName, GroupType category, string optionName, string subOptionName, bool isActive)
        {
            if (Options.ContainsKey(hostName) && Options[hostName].ContainsKey(category))
            {
                if (!string.IsNullOrEmpty(subOptionName))
                    Options[hostName][category].FirstOrDefault(x => x.Name == optionName).SubMethodParams.FirstOrDefault(x => x.Name == subOptionName).IsActive = isActive;
                else
                    Options[hostName][category].FirstOrDefault(x => x.Name == optionName).IsActive = isActive;
            }
        }

        public async Task<bool> UpdateCostCooldown(string hostName, int previousCost, int cost, int cooldown)
        {
            if (this.OptionCooldowns[hostName].ContainsKey(previousCost))
            {
                if (previousCost == cost)
                {
                    this.OptionCooldowns[hostName][previousCost] = cooldown;
                }
                else
                {
                    this.OptionCooldowns[hostName].Remove(previousCost);
                    this.OptionCooldowns[hostName].Add(cost, cooldown);

                    foreach (var category in Options[hostName])
                    {
                        Options[hostName][category.Key].ForEach(x =>
                        {
                            x.SubMethodParams.Where(x => x.Cost == previousCost).ToList().ForEach(x => x.Cost = cost);
                        });
                    }
                }

                return true;
            }
            else if (!this.OptionCooldowns[hostName].ContainsKey(cost))
            {
                this.OptionCooldowns[hostName].Add(cost, cooldown);

                return true;
            }

            return false;
        }

        public async Task<bool> AddCostCooldown(string hostName, int cost, int cooldown)
        {
            if (!this.OptionCooldowns[hostName].ContainsKey(cost))
            {
                this.OptionCooldowns[hostName].Add(cost, cooldown);

                return true;
            }

            return false;
        }

        public async Task<bool> ImportOptionCostCooldown(string hostName, IFileListEntry file)
        {
            try
            {
                using var streamReader = new StreamReader(file.Data);
                var content = await streamReader.ReadToEndAsync();

                var optionSettings = JsonSerializer.Deserialize<ImportExportOptionSettings>(content);

                foreach (var (optionSettingCategory, settings) in optionSettings.Settings)
                {
                    var category = Enum.Parse<GroupType>(optionSettingCategory);

                    foreach (var (settingName, subSettings) in settings)
                    {
                        Options[hostName][category]
                            .FirstOrDefault(x => x.Name == settingName).IsActive = subSettings.FirstOrDefault(y => y.OptionName == settingName).IsActive;

                        Options[hostName][category]
                            .FirstOrDefault(x => x.Name == settingName)
                                .SubMethodParams
                                .ForEach(x =>
                                {
                                    x.Cost = subSettings.FirstOrDefault(y => y.OptionName == x.Name).Cost;
                                    x.IsActive = subSettings.FirstOrDefault(y => y.OptionName == x.Name).IsActive;
                                });
                    }
                }

                this.OptionCooldowns[hostName] = optionSettings.CostCooldowns.ToDictionary(x => int.Parse(x.Key), x => int.Parse(x.Value));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }

            return true;
        }

        public async Task<string> ExportOptionCostCooldown(string hostName)
        {
            string result = string.Empty;

            try
            {
                var optionSettings = new ImportExportOptionSettings()
                {
                    Settings = new Dictionary<string, Dictionary<string, List<Setting>>>(),
                    CostCooldowns = this.OptionCooldowns[hostName].ToDictionary(x => x.Key.ToString(), x => x.Value.ToString())
                };

                foreach (var (category, options) in Options[hostName])
                {
                    var categoryString = category.ToString();

                    foreach (var option in options)
                    {
                        var settings = option.SubMethodParams.Select(x => new Setting
                        {
                            OptionName = x.Name,
                            Cost = x.Cost,
                            IsActive = x.IsActive
                        }).ToList();


                        settings.Add(new Setting
                        {
                            OptionName = option.Name,
                            Cost = option.Cost,
                            IsActive = option.IsActive
                        });

                        if (!optionSettings.Settings.ContainsKey(categoryString))
                            optionSettings.Settings.Add(categoryString, new Dictionary<string, List<Setting>>());

                        if (!optionSettings.Settings[categoryString].ContainsKey(option.Name))
                            optionSettings.Settings[categoryString].Add(option.Name, new List<Setting>());

                        optionSettings.Settings[categoryString][option.Name].AddRange(settings);
                    }
                }

                result = JsonSerializer.Serialize(optionSettings, new JsonSerializerOptions { IgnoreNullValues = false });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return string.Empty;
            }

            return result;
        }

        #endregion Option Instantiation and Update

        #region Timers

        public void CreateTimer(string hostName, string optionName, int time)
        {
            if (!CooldownTimers.ContainsKey(hostName))
                CooldownTimers.Add(hostName, new Dictionary<string, Timer>());

            if (!CooldownTimers[hostName].ContainsKey(optionName))
                CooldownTimers[hostName].Add(optionName, null);

            this.SetButtonAble(hostName, optionName, true);

            var callbackEvent = new TimerCallback((e) =>
            {
                this.SetButtonAble(hostName, optionName, false);

                CooldownTimers[hostName].Remove(optionName);
            });

            CooldownTimers[hostName][optionName] = new Timer(callbackEvent, null, time * 1000, Timeout.Infinite);
        }

        private void SetButtonAble(string hostName, string optionName, bool isDisabled)
        {
            try
            {
                Options[hostName].Values
                    .FirstOrDefault(x => x.Any(y => y.Name == optionName))
                    .FirstOrDefault(x => x.Name == optionName).IsDisabled = isDisabled;

                Options[hostName].Values
                    .FirstOrDefault(x => x.Any(y => y.Name == optionName))
                    .FirstOrDefault(x => x.Name == optionName)
                    .SubMethodParams.ForEach(x => x.IsDisabled = isDisabled);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MemoryService.TimerUpdated(this, new ChangeEventArgs());
            }
        }

        #endregion Timers

        #region Events

        public static void TimerUpdated(object sender, ChangeEventArgs e)
        {
            OnTimerChanged?.Invoke(sender, e);
        }

        #endregion Events
    }
}