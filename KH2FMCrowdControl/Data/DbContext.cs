using KH2FMCrowdControl.Twitch;
using System;
using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class DbContext
    {
        // Key: username - Value: credentials
        public static Dictionary<string, Host> Hosts = new Dictionary<string, Host>();

        // Key: username - Value: button values
        public static Dictionary<string, List<Option>> ActiveOptions = new Dictionary<string, List<Option>>();
    }
}