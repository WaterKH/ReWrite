using System.Collections.Generic;

namespace KH2FMCrowdControl.Twitch
{
    public class TwitchUserInfo
    {
        public string client_id { get; set; }
        public string login { get; set; }
        public List<string> scopes { get; set; }
        public string user_id { get; set; }
        public long expires_in { get; set; }
    }
}