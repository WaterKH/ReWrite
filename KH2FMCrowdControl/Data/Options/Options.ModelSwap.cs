using System.Collections.Generic;
using System.Threading.Tasks;
using Waterkh.Common.Memory;

namespace KH2FMCrowdControl.Data
{
    public partial class Options
    {
        public async Task<List<ButtonTemplate>> InitializeModelSwapOptions()
        {
            var options = new List<ButtonTemplate>();

            options.AddRange(await this.InitializeResetModelSwapOptions());

            options.AddRange(await this.InitializeSoraModelSwapOptions());
            options.AddRange(await this.InitializeDonaldModelSwapOptions());
            options.AddRange(await this.InitializeGoofyModelSwapOptions());

            options.AddRange(await this.InitializeMulanModelSwapOptions());
            options.AddRange(await this.InitializeBeastModelSwapOptions());
            options.AddRange(await this.InitializeAuronModelSwapOptions());
            options.AddRange(await this.InitializeCaptainJackSparrowModelSwapOptions());
            options.AddRange(await this.InitializeAladdinModelSwapOptions());
            options.AddRange(await this.InitializeJackSkellingtonModelSwapOptions());
            options.AddRange(await this.InitializeSimbaModelSwapOptions());
            options.AddRange(await this.InitializeTronModelSwapOptions());
            options.AddRange(await this.InitializeRikuModelSwapOptions());

            return options;
        }

        public async Task<List<ButtonTemplate>> InitializeResetModelSwapOptions()
        {
            // TODO Potentially Expand this to do All, Per World, etc.
            var options = new List<ButtonTemplate>
            {
                new ButtonTemplate
                {
                    Name = "Reset All",
                    Category = GroupType.ModelSwap,
                    SubCategory = SubGroupType.None,
                    Cost = Constants.Cost1000,
                    Description = "Resets All Model Swaps",
                    ImageUrl = "Characters/Sora.png",
                    ManipulationType = ManipulationType.Set,
                    Value = "",
                    MethodName = "SendResetModelSwapsMessage"
                }
            };

            return options;
        }
    }
}
