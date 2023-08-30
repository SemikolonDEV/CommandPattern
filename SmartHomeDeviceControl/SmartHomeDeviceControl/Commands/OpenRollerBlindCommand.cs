using SmartHomeDeviceControl.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDeviceControl.Command;

internal class OpenRollerBlindCommand : ICommand
{

    private RollingBlind _rollingBlind;

    public OpenRollerBlindCommand(RollingBlind rollingBlind)
    {
            _rollingBlind = rollingBlind;
    }

    public void Execute()
    {
        _rollingBlind.Open();
    }
}
