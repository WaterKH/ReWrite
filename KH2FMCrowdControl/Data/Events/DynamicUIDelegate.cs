using System;
using System.Threading.Tasks;

namespace KH2FMCrowdControl.Data
{
    public delegate Task DynamicUIDelegate(object sender, DynamicUIArgs e);

    public class DynamicUIEvent : EventArgs
    {
        
    }
}