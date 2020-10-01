using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public delegate Task TimerDelegate(object sender, ChangeEventArgs e);

    public class TimerEvent : EventArgs
    {
        
    }
}