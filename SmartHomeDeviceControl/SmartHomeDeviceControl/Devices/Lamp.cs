using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDeviceControl.Devices;

public class Lamp
{
    public bool IsOn { get; private set; }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Lamp turned on");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Lamp turned off");
    }
}
