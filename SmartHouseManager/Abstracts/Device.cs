using SmartHouseManager.Realizer;

namespace SmartHouseManager.Abstracts;

public class Device
{
    protected IDeviceManager _deviceManager;
    
    public void SetDeviceManager(IDeviceManager deviceManager)
    {
        _deviceManager = deviceManager;
    }

    public Device(IDeviceManager deviceManager)
    {
        _deviceManager = deviceManager;
    }
    
    public void TurnOff()
    {
        _deviceManager.TurnOff();
    }
    
    public void TurnOn()
    {
        _deviceManager.TurnOn();
    }
    
    public void IncreaseVolume()
    {
        _deviceManager.IncreaseVolume();
    }
}