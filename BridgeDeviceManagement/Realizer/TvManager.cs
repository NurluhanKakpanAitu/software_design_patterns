namespace BridgeDeviceManagement.Realizer;

public class TvManager : IDeviceManager
{
    public void TurnOff()
    {
        Console.WriteLine("TV is turning off.");
    }

    public void TurnOn()
    {
        Console.WriteLine("TV is turning on.");
    }

    public void SoundIncrease()
    {
        Console.WriteLine("TV sound is increasing.");
    }

    public void SoundDecrease()
    {
        Console.WriteLine("TV sound is decreasing.");
    }

    public void SwitchChannel()
    {
        Console.WriteLine("TV channel is switching.");
    }
}