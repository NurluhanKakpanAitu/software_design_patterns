using BridgeDeviceManagement.Realizer;

namespace BridgeDeviceManagement.Abstracts;

public abstract class Device(IDeviceManager deviceManager)
{
    protected IDeviceManager _deviceManager = deviceManager;

    public void SetDeviceManager(IDeviceManager deviceManager)
    {
        _deviceManager = deviceManager;
    }
    
    public void TurnOn()
    {
        _deviceManager.TurnOn();
    }
    
    public void TurnOff()
    {
        _deviceManager.TurnOff();
    }
    
    public void SoundIncrease()
    {
        _deviceManager.SoundIncrease();
    }
    public void SoundDecrease()
    {
        _deviceManager.SoundDecrease();
    }
    public void SwitchChannel()
    {
        _deviceManager.SwitchChannel();
    }
    
}