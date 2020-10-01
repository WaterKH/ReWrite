using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public delegate Task HostsDelegate(object sender, ChangeEventArgs e);

    public class HostsEvent : EventArgs
    {
        
    }
}