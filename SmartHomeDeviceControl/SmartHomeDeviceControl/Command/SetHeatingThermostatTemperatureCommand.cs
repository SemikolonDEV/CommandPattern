using SmartHomeDeviceControl.Devices;

namespace SmartHomeDeviceControl.Command;

public class SetHeatingThermostatTemperatureCommand : ICommand
{
    private HeatingThermostat _heatingThermostat;

    private double _temperature;

    public SetHeatingThermostatTemperatureCommand(HeatingThermostat heatingThermostat, double temperature)
    {
        _heatingThermostat = heatingThermostat;
        _temperature = temperature;
    }

    public void Execute()
    {
        _heatingThermostat.SetTemperature(_temperature);
    }
}
