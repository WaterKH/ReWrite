using System;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public delegate Task AlertDelegate(object sender, AlertArgs e);

    public class AlertEvent : EventArgs
    {
        
    }
}