namespace SmartHouseManager.Realizer;

public class MobileAppManager : IDeviceManager
{
    public void TurnOff()
    {
        Console.WriteLine("Turning off the device from the mobile app");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on the device from the mobile app");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Increasing the volume from the mobile app");
    }
}