using System;
using System.Collections.Generic;

namespace KH2FMCrowdControl.Data
{
    public class DynamicUIArgs : EventArgs
    {
        public string HostName { get; set; }
        public List<string> Options{ get; set; }
    }
}