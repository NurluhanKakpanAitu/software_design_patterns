namespace SmartHouseManager.Realizer;

public class VoiceManager : IDeviceManager
{
    public void TurnOff()
    {
        Console.WriteLine("Turning off the device from the voice assistant");
    }

    public void TurnOn()
    {
        Console.WriteLine("Turning on the device from the voice assistant");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Voice assistant does not support volume control. Please use the web interface or mobile app.");
    }
}