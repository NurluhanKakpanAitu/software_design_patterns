using BridgeDeviceManagement.Abstracts;
using BridgeDeviceManagement.Realizer;

class Program
{
    static void Main(string[] args)
    {
        var tv = new Tv(new TvManager());
        var radio = new Radio(new RadioManager());
        tv.SwitchChannel();
        radio.SwitchChannel();
    }
}