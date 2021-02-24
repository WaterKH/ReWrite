using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Waterkh.Common.Mappings;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeEnvironmentOptions()
        {
            List<ButtonTemplate> worlds = new List<ButtonTemplate>();

            WorldRoomMapping.Worlds.Values.ToList().ForEach(x => worlds.Add(new ButtonTemplate { Name = x.Name, Cost = Constants.Cost3000, Value = x.Value, ManipulationType = ManipulationType.Set, ImageUrl = "Worlds/" + x.ImageUrl }));


            var roomModifier = new List<ButtonTemplate>();

            worlds.CreateListFromList().ForEach(x => {

                var rooms = new List<ButtonTemplate>();

                foreach((string name, int id) in WorldRoomMapping.Rooms[(int)x.Value])
                {
                    rooms.Add(new ButtonTemplate { Name = name, Cost = Constants.Cost1000, Value = id, ManipulationType = ManipulationType.Set, ImageUrl = x.ImageUrl });
                }

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
                    Tag = FeatureTagType.Unstable,
                    Cost = 0,
                    Description = "Change the next room to a different one",
                    ImageUrl = "Worlds/Hollow_Bastion.png",
                    SubMethodParams = roomModifier
                },
            };

            return options;
        }
    }
}