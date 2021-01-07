using KH2FMCrowdControl.Twitch;

namespace KH2FMCrowdControl.Data
{
    public class Host
    {
        public string ConnectionId { get; set; }
        public bool IsHosting { get; set; }
        public TwitchApi TwitchApi { get; set; }
        public string DisplayName { get; set; }
        public string ImageUrl {get; set;}
        public string StreamUrl { get; set; }
    }
}