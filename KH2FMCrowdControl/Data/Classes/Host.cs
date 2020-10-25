using KH2FMCrowdControl.Twitch;

namespace KH2FMCrowdControl.Data
{
    public class Host
    {
        public string ConnectionId { get; set; }
        public bool IsHosting { get; set; }

        public TwitchApi TwitchApi { get; set; }
    }
}