using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class DbContext
    {
        // Key: username - Value: credentials
        public static Dictionary<string, Host> Hosts = new Dictionary<string, Host>();
    }
}