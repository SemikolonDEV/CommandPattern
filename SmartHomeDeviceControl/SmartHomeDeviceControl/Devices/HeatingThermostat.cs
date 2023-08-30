namespace SmartHomeDeviceControl.Devices
{
    public class HeatingThermostat
    {

        public double Temperature { get; private set; } = 18.0;

        public void IncementTempreature()
        {
            Temperature++;
            PrintTempValue();
        }

        public void DecrementTempretaure()
        {
            Temperature--;
            PrintTempValue();
        }

        public void SetTemperature(double temperature)
        {
            if (temperature > 28 || temperature < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(temperature));
            }
            Temperature = temperature;
            PrintTempValue();
        }

        private void PrintTempValue()
        {
            Console.WriteLine($"New Temperature is {Temperature}°C");
        }
    }
}
