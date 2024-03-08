namespace SmartHouseManager.Realizer;

public class WebInterfaceManager : IDeviceManager
{
    public void TurnOff()
    {
        Console.WriteLine("Turning off the device from the web interface");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on the device from the web interface");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Increasing the volume from the web interface");
    }
}