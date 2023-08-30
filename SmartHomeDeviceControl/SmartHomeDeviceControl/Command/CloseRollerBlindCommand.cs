using SmartHomeDeviceControl.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeDeviceControl.Command;

internal class CloseRollerBlindCommand : ICommand
{

    private RollingBlind _rollingBlind;

    public CloseRollerBlindCommand(RollingBlind rollingBlind)
    {
        _rollingBlind = rollingBlind;
    }

    public void Execute()
    {
        _rollingBlind.Close();
    }
}
