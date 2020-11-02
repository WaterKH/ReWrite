using System;

namespace KH2FMCrowdControl.Data
{
    public class MessageHubArgs : EventArgs
    {
        public string HostName { get; set; }
        public string ConnectionId { get; set; }
        public string ConnectionStatus { get; set; }
    }
}