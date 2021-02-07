using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public static class VersionHistoryMappings
    {
        public static Dictionary<int, VersionHistory> VersionHistories = new Dictionary<int, VersionHistory>
        {
            { 3, new VersionHistory { Version = 0.3, Title = "Stability fix for Model Swapping + bug fixes", IsComplete = true, Description = @"
                    Features:
                    + Customize Menu options added.

                    Bug Fixes:
                    + Model Swap Hitboxes addressed.
                    + Stability fix for model swapping Sora.
                    + Moved Abilities to Client and send down Ability Name to client.

                    Misc:
                    + Added urls and Magic to Constants.
                    + Added Parent Name to Alert." 
                } 
            },
            { 4, new VersionHistory { Version = 0.4, Title = "Different Sora Models + Party Ability Options + Enemy Update", IsComplete = true, Description = @"
                    Features:
                    + Party Members now have options to customize, including Abilities and Equipment.
                    + Model Swapping has been added for Party Members. As of right now, World Specific Skins are causing issues, so a new issue will be created to address this.
                    + Enemy Update: This update added in support for changing the bosses that appear in worlds, as well as change Health, Strength and Defense, both at once and with timers.

                    Bug Fixes:
                    +Popups should no longer close when other people select an option.

                    Misc:
                    + Added support for sub-option windows - although this dims the screen each dig. As well as this creates a bug where the option does not react to being closed."
                }
            },
            { 5, new VersionHistory { Version = 0.5, Title = "Stat Changes + Model Timers + Misc Bug Fixes", IsComplete = true, Description = @"
                    Features:
                    + Client & Server Logging implemented. Log.txt will be stored locally for bugs that may be caught.
                    + Stat Change Persistance - Allows for Sora's Strength/ Magic/ Defense to be manipulated outright as well as timer based. HP and Magic are also included in these timers [Pro Codes].

                    Bug Fixes:
                    + I think what happened was a client/ server miscommunication that has been addressed with the new client.
                    + Boss Change now disallows people from selecting another one, implementing cooldowns.
                    + Model Swapping for Event Triggers now sets the correct model for Sora when viewing an event - Meaning Twilight Town sets to Roxas, Pride Lands sets to Lion Sora, etc.
                    + Model Swapped characters can now open chests.

                    Misc:
                    + Added in ModelSwap for different world skins."
                }
            },
            { 6, new VersionHistory { Version = 0.6, Title = "Client Cache + Misc Bug Fixes", IsComplete = true, Description = @"
                    Features:
                    + Client Cache added (Client side).

                    Bug Fix:
                    + Removed Beast as Sora for now, will move him back in when Model Timers becomes implemented.

                    Misc:
                    + Removed duplicate method GetHost."
                }
            },
            { 7, new VersionHistory { Version = 0.7, Title = "UI/ Layout Overhaul", IsComplete = true, Description = @"
                    Features:
                    + Major UI Overhaul w/ Mattie - Including new Index, Host and Viewer pages.
                    + Icons all updated by Mattie.

                    Bug Fixes:
                    + Some Party member Models weren't working.
                    + Fixed a critical bug with updating Points per Second for Viewers.
                    + Fixed a critical bug for updating a duplicate cost/cooldown.
                    + Addressed an issue that now disables both Ally and Enemy Option redemptions when one of them is selected.

                    Misc:
                    + Removed the SubCategory for Abilities, will add back if necessary."
                }
            },
            { 8, new VersionHistory { Version = 0.8, Title = "UI/ Layout Overhaul", IsComplete = true, Description = @"
                    Features:\n
                    + Added an option to Reset All ModelSwaps.\n
                    + Host Overhaul: Add the ability to view viewer page, setup host and pause hosting.\n
                    + Added Timers for ModelSwaps so now characters will revert on room change after 45 seconds.\n
\n
                    Bug Fixes:\n
                    + Magic QuickMenu setting now works.\n
                    + A slew of Party related fixes: Party Select screen/ Menu screen, Party Member Swapping disabled and removed multiple of the same Party Member.\n
                    + Fixed Instant Driving from option. Turned out it was missing a string identifier.\n

                    Misc:
                    + Added some images that were missing/ not correct, as well as smaller icon for Re:Write in top left of certain pages."
                }
            },
            { 9, new VersionHistory { Version = 0.9, Title = "Room Randomizing + Magic Update + Model Swap Enhancements", IsComplete = true, Description = @"
                    0.9.0 Update (Room Randomizing Update)

                    Features:
                    + Added an option to Randomize the next Room. - Closes #9
                    + Wanted to do a lot more with the Magic Update, but as of right now Magic Costs have been added. - Closes #20
                    + Added an option to change Forms (Valor, Wisdom, etc). - Closes #52
                    + Added the ability to turn all Drives on/ off. - Closes #58
                    + Added an option to randomize Party Members. - Closes #61

                    Bug Fixes:
                    + Speed up x3 reduced, it was too fast. - Fixes #57

                    Misc:
                    + Hosting Issue closed earlier due to overhaul and not able to reproduce. - Refs #51
                    + Preliminary Version History Added to Home Page." 
                }
            },
            { 10, new VersionHistory { Version = 1.0, Title = "Finalizing touches that need to be completed for release", IsComplete = false, Description = @"" }
            },
        };
    }
}
