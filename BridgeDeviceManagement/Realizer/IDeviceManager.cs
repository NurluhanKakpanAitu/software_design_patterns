namespace BridgeDeviceManagement.Realizer;

public interface IDeviceManager
{
    public void TurnOff();

    public void TurnOn();

    public void SoundIncrease();

    public void SoundDecrease();

    public void SwitchChannel();
}