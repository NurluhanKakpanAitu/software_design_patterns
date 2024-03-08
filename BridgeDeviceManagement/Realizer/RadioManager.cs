namespace BridgeDeviceManagement.Realizer;

public class RadioManager : IDeviceManager
{
    public void TurnOff()
    {
        Console.WriteLine("Radio is turning off.");
    }

    public void TurnOn()
    {
        Console.WriteLine("Radio is turning on.");
    }

    public void SoundIncrease()
    {
        Console.WriteLine("Radio sound is increasing.");
    }

    public void SoundDecrease()
    {
        Console.WriteLine("Radio sound is decreasing.");
    }

    public void SwitchChannel()
    {
        Console.WriteLine("Radio channel is switching.");
    }
}