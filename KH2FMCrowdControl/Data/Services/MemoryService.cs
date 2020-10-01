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
        public Dictionary<string, Dictionary<GroupType, List<KHButtonTemplate>>> CurrentOptions;

        public Dictionary<string, Dictionary<string, Timer>> Cooldowns = new Dictionary<string, Dictionary<string, Timer>>();

        public static event AlertDelegate OnAlertReceived;

        private readonly Options options;

        public static void SendAlert(object sender, AlertArgs e)
        {
            OnAlertReceived?.Invoke(sender, e);
        }

        public MemoryService(IHubContext<MessageHub> context)
        {
            options = new Options(context);
        }

        #region Option Instantiation and Update

        public async Task InitializeOptions(string hostName)
        {
            this.CurrentOptions = new Dictionary<string, Dictionary<GroupType, List<KHButtonTemplate>>> { 
                { hostName, await this.options.InitializeOptions() }
            };
        }

        public async Task UpdateOptions(string hostName)
        {
            DbContext.ActiveOptions.TryGetValue(hostName, out var options);

            if (options == null)
                return;

            foreach (var option in options)
            {
                //this.CurrentOptions[hostName][option.Category].Cost = option.Cost;
                //this.CurrentOptions[hostName][option.Category].IsActive = option.IsActive;
            }
        }

        #endregion Option Instantiation and Update

        #region Timers

        public void CreateTimer(string hostName, string optionName, int time)
        {
            if (!Cooldowns.ContainsKey(hostName))
                Cooldowns.Add(hostName, new Dictionary<string, Timer>());

            if (!Cooldowns[hostName].ContainsKey(optionName))
                Cooldowns[hostName].Add(optionName, null);

            this.SetButtonAble(hostName, optionName, true);

            var callbackEvent = new TimerCallback((e) =>
            {
                this.SetButtonAble(hostName, optionName, false);
            });

            Cooldowns[hostName][optionName] = new Timer(callbackEvent, null, time * 1000, Timeout.Infinite);
        }

        private void SetButtonAble(string hostName, string optionName, bool isDisabled)
        {
            try
            {
                this.CurrentOptions[hostName].Values
                    .FirstOrDefault(x => x.Any(y => y.Name == optionName))
                    .FirstOrDefault(x => x.Name == optionName).IsDisabled = isDisabled;

                this.CurrentOptions[hostName].Values
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