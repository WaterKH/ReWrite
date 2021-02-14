using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class DbContext
    {
        // Key: username - Value: credentials
        public static Dictionary<string, Host> Hosts = new Dictionary<string, Host>();

        // Key: Host username - Value: points per second
        public static Dictionary<string, PointCounter> Points = new Dictionary<string, PointCounter>();

        // Key: Host username - Value: AlertSettings
        public static Dictionary<string, AlertSettings> AlertSettings = new Dictionary<string, AlertSettings>();

        // Key: Host username - Value: Alerts
        public static Dictionary<string, List<KHAlert>> Alerts = new Dictionary<string, List<KHAlert>>();
    }
}