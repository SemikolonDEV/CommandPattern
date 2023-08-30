using SmartHomeDeviceControl;
using SmartHomeDeviceControl.Command;
using SmartHomeDeviceControl.Devices;

var deviceController = new DeviceController();

var lamp = new Lamp();

var turOnCommand = new TurnLampOnCommand(lamp);

deviceController.ExecuteCommand(turOnCommand);

var turnOffCommand = new TurnLampOffCommand(lamp);

deviceController.ExecuteCommand(turnOffCommand);

var heatingThermostat = new HeatingThermostat();

var setTemperatureCommand = new SetHeatingThermostatTemperatureCommand(heatingThermostat, 20.2);

deviceController.ExecuteCommand(setTemperatureCommand);
