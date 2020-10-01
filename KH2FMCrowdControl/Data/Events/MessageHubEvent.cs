using System;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public delegate Task MessageHubDelegate(object sender, MessageHubArgs e);

    public class MessageHubEvent : EventArgs
    {
        
    }
}