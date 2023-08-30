using SmartHomeDeviceControl.Devices;

namespace SmartHomeDeviceControl.Command;

public class TurnLampOffCommand : ICommand
{
    private Lamp _lamp;

    public TurnLampOffCommand(Lamp lamp)
    {
        _lamp = lamp;
    }

    public void Execute()
    {
        _lamp.TurnOff();
    }
}
