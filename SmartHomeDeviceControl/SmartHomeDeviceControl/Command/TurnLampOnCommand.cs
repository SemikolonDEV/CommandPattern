using SmartHomeDeviceControl.Devices;

namespace SmartHomeDeviceControl.Command;

public class TurnLampOnCommand : ICommand
{
    private Lamp _lamp;

    public TurnLampOnCommand(Lamp lamp)
    {
        _lamp = lamp;
    }

    public void Execute()
    {
        _lamp.TurnOn();
    }
}
