namespace SmartHomeDeviceControl.Devices;

public class RollingBlind
{

    public bool IsOpen { get; private set; }

    public void Open()
    {
        IsOpen = true;
        Console.WriteLine("Open Roller Blind");
    }

    public void Close()
    {
        IsOpen = false;
        Console.WriteLine("Close Roller Blind");
    }

}
