using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public delegate Task UserCoinDelegate(object sender, ChangeEventArgs e);

    public class UserCoinEvent : EventArgs
    {
        
    }
}