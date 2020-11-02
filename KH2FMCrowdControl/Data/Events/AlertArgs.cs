using System;

namespace KH2FMCrowdControl.Data
{
    public class AlertArgs : EventArgs
    {
        public string Host { get; set; }
        public string Viewer { get; set; }
        public string Item { get; set; }
        public string ImageUrl { get; set; }
    }
}