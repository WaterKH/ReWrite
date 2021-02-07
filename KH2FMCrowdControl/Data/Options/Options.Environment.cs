using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeEnvironmentOptions()
        {
            List<ButtonTemplate> worlds = new List<ButtonTemplate>();

            WorldRoomMappings.Worlds.Values.ToList().ForEach(x => worlds.Add(new ButtonTemplate { Name = x.Name, Cost = Constants.Cost3000, Value = x.Value, ManipulationType = ManipulationType.Set, ImageUrl = x.ImageUrl }));


            var roomModifier = new List<ButtonTemplate>();

            worlds.CreateListFromList().ForEach(x => {

                var rooms = new List<ButtonTemplate>();
                WorldRoomMappings.Rooms[(int)x.Value].Values.ToList().ForEach(r => rooms.Add(new ButtonTemplate { Name = x.Name, Cost = Constants.Cost1000, Value = x.Value, ManipulationType = ManipulationType.Set, ImageUrl = x.ImageUrl }));

                x.SubMethodParams = rooms;
                x.SubMethodParams.ForEach(y => { 
                    y.Value += $":{x.Value}"; // Room:World
                    y.MethodName = "SendRoomChangeMessage";
                });

                x.Cost = 0;

                roomModifier.Add(x);
            });

            var options = new List<ButtonTemplate>() {

                new ButtonTemplate
                {
                    Name = "Change Room",
                    Category = GroupType.Environment,
                    SubCategory = SubGroupType.Rooms,
                    Cost = 0,
                    Description = "Change the next room to a different one",
                    ImageUrl = "Worlds/Hollow_Bastion.png",
                    SubMethodParams = roomModifier
                },
                // TODO Change Chests?
            };

            return options;
        }
    }
}