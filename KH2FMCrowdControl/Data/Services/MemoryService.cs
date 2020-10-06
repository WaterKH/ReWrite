using Blazored.Toast.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public class MemoryService
    {
        public static event TimerDelegate OnTimerChanged;

        // Key: Host Name - Key: Category Name - Value: Buttons
        public Dictionary<string, Dictionary<GroupType, List<KHButtonTemplate>>> Options;
        public Dictionary<string, Dictionary<int, int>> OptionCooldowns;

        public Dictionary<string, Dictionary<string, Timer>> CooldownTimers = new Dictionary<string, Dictionary<string, Timer>>();
        
        public static event AlertDelegate OnAlertReceived;

        private readonly Options options;

        public static void SendAlert(object sender, AlertArgs e)
        {
            OnAlertReceived?.Invoke(sender, e);
        }

        public MemoryService(IHubContext<MessageHub> context)
        {
            options = new Options(context);

            this.Options = new Dictionary<string, Dictionary<GroupType, List<KHButtonTemplate>>>();
            this.OptionCooldowns = new Dictionary<string, Dictionary<int, int>>();
        }

        #region Option Instantiation and Update

        public async Task InitializeOptions(string hostName)
        {
            if(!this.Options.ContainsKey(hostName))
                this.Options.Add(hostName, await this.options.InitializeOptions());

            if (!this.OptionCooldowns.ContainsKey(hostName))
                this.OptionCooldowns.Add(hostName, Constants.Cooldowns.ToDictionary(x => x.Key, x => x.Value));
        }

        public async Task UpdateOption(string hostName, GroupType category, string optionName, string subOptionName, int cost, bool isActive)
        {
            if (this.Options.ContainsKey(hostName) && this.Options[hostName].ContainsKey(category))
            {
                if (!string.IsNullOrEmpty(subOptionName))
                {
                    this.Options[hostName][category].FirstOrDefault(x => x.Name == optionName).SubMethodParams.FirstOrDefault(x => x.Name == subOptionName).Cost = cost;
                    this.Options[hostName][category].FirstOrDefault(x => x.Name == optionName).SubMethodParams.FirstOrDefault(x => x.Name == subOptionName).IsActive = isActive;
                }
                else
                {
                    this.Options[hostName][category].FirstOrDefault(x => x.Name == optionName).Cost = cost;
                    this.Options[hostName][category].FirstOrDefault(x => x.Name == optionName).IsActive = isActive;
                }
            }
        }

        public async Task<bool> UpdateCostCooldown(string hostName, int previousCost, int cost, int cooldown)
        {
            if(this.OptionCooldowns[hostName].ContainsKey(previousCost))
            {
                if (previousCost == cost)
                {
                    this.OptionCooldowns[hostName][previousCost] = cooldown;
                }
                else
                {
                    this.OptionCooldowns[hostName].Remove(previousCost);
                    this.OptionCooldowns[hostName].Add(cost, cooldown);

                    foreach (var category in this.Options[hostName])
                    {
                        this.Options[hostName][category.Key].ForEach(x =>
                        {
                            x.SubMethodParams.Where(x => x.Cost == previousCost).ToList().ForEach(x => x.Cost = cost);
                        });
                    }
                }

                return true;
            }
            else if(!this.OptionCooldowns[hostName].ContainsKey(cost))
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
                this.Options[hostName].Values
                    .FirstOrDefault(x => x.Any(y => y.Name == optionName))
                    .FirstOrDefault(x => x.Name == optionName).IsDisabled = isDisabled;

                this.Options[hostName].Values
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