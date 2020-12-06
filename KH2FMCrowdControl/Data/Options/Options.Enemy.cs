using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeEnemyOptions()
        {
            List<ButtonTemplate> enemies = new List<ButtonTemplate>();

            EnemyMappings.Enemies.Values.ToList().ForEach(x => enemies.Add(new ButtonTemplate { Name = x.Name, Cost = Constants.Cost3000, Value = x.Name, ManipulationType = ManipulationType.Set, ImageUrl = "Enemy/Boss.png" }));

            var bossModelModifier = new List<ButtonTemplate>();

            enemies.CreateListFromList().ForEach(x => {
                x.SubMethodParams = enemies.CreateListFromList();
                x.SubMethodParams.ForEach(y => { 
                    y.Value += $":{x.Name}"; 
                    y.MethodName = "SendBossChangeMessage";
                });

                x.Cost = 0;
                
                bossModelModifier.Add(x);
            });

            var options = new List<ButtonTemplate>() {

                new ButtonTemplate
                {
                    Name = "Change Boss",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Change the Boss selected to a different one",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = bossModelModifier
                },
                new ButtonTemplate
                {
                    Name = "Activate Health Timer",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Adds a timer that will change health every x amount of time",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = enemies.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Deactivate Health Timer",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Removes a timer that will change health every x amount of time",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = enemies.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Activate Strength Timer",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Adds a timer that will change Strength every x amount of time",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = enemies.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Deactivate Strength Timer",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Removes a timer that will change Strength every x amount of time",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = enemies.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Activate Defense Timer",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Adds a timer that will change defense every x amount of time",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = enemies.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Deactivate Defense Timer",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Removes a timer that will change defense every x amount of time",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = enemies.CreateListFromList()
                },
                new ButtonTemplate
                {
                    Name = "Change Max Health",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Changes boss's max health",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Max Health", Value = "Max", ManipulationType = ManipulationType.Set, Description = "Sets Boss Health To Max", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "Half Health", Value = "Half", ManipulationType = ManipulationType.Set, Description = "Sets Boss Health To Half", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "One Hit Health", Value = "One", ManipulationType = ManipulationType.Set, Description = "Sets Boss Health To One", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Health",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Changes boss's health",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Max Health", Value = "Max", ManipulationType = ManipulationType.Set, Description = "Sets Boss Health To Max", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "Half Health", Value = "Half", ManipulationType = ManipulationType.Set, Description = "Sets Boss Health To Half", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "One Hit Health", Value = "One", ManipulationType = ManipulationType.Set, Description = "Sets Boss Health To One", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Strength",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Changes boss's Strength",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Max Strength", Value = "Max", ManipulationType = ManipulationType.Set, Description = "Sets Boss Strength To Max", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "Half Strength", Value = "Half", ManipulationType = ManipulationType.Set, Description = "Sets Boss Strength To Half", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "Zero Strength", Value = "Zero", ManipulationType = ManipulationType.Set, Description = "Sets Boss Strength To Zero", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                    }
                },
                new ButtonTemplate
                {
                    Name = "Change Defense",
                    Category = GroupType.Enemy,
                    Cost = 0,
                    Description = "Changes boss's defense",
                    ImageUrl = "Enemy/Boss.png",
                    SubMethodParams = new List<ButtonTemplate>
                    {
                        new ButtonTemplate { Name = "Max Defense", Value = "Max", ManipulationType = ManipulationType.Set, Description = "Sets Boss Defense To Max", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "Half Defense", Value = "Half", ManipulationType = ManipulationType.Set, Description = "Sets Boss Defense To Half", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                        new ButtonTemplate { Name = "Zero Defense", Value = "Zero", ManipulationType = ManipulationType.Set, Description = "Sets Boss Defense To Zero", ImageUrl = "Enemy/Boss.png", SubMethodParams = enemies.CreateListFromList() },
                    }
                },
            };

            options.FirstOrDefault(x => x.Name.Equals("Activate Health Timer")).SubMethodParams.ForEach(x => x.MethodName = "SendBossActivateHealthTimerMessage");
            options.FirstOrDefault(x => x.Name.Equals("Deactivate Health Timer")).SubMethodParams.ForEach(x => x.MethodName = "SendBossDeactivateHealthTimerMessage");
            options.FirstOrDefault(x => x.Name.Equals("Activate Strength Timer")).SubMethodParams.ForEach(x => x.MethodName = "SendBossActivateStrengthTimerMessage");
            options.FirstOrDefault(x => x.Name.Equals("Deactivate Strength Timer")).SubMethodParams.ForEach(x => x.MethodName = "SendBossDeactivateStrengthTimerMessage");
            options.FirstOrDefault(x => x.Name.Equals("Activate Defense Timer")).SubMethodParams.ForEach(x => x.MethodName = "SendBossActivateDefenseTimerMessage");
            options.FirstOrDefault(x => x.Name.Equals("Deactivate Defense Timer")).SubMethodParams.ForEach(x => x.MethodName = "SendBossDeactivateDefenseTimerMessage");

            options.FirstOrDefault(x => x.Name.Equals("Change Max Health")).SubMethodParams.ForEach(x => x.SubMethodParams.ForEach(y => { y.MethodName = "SendBossMaxHealthChangeMessage"; y.Value += $":{x.Value}"; }));
            options.FirstOrDefault(x => x.Name.Equals("Change Health")).SubMethodParams.ForEach(x => x.SubMethodParams.ForEach(y => { y.MethodName = "SendBossHealthChangeMessage"; y.Value += $":{x.Value}"; }));
            options.FirstOrDefault(x => x.Name.Equals("Change Strength")).SubMethodParams.ForEach(x => x.SubMethodParams.ForEach(y => { y.MethodName = "SendBossStrengthChangeMessage"; y.Value += $":{x.Value}"; }));
            options.FirstOrDefault(x => x.Name.Equals("Change Defense")).SubMethodParams.ForEach(x => x.SubMethodParams.ForEach(y => { y.MethodName = "SendBossDefenseChangeMessage"; y.Value += $":{x.Value}"; }));

            return options;
        }
    }
}