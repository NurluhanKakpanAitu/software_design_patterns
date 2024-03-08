using SmartHouseManager.Abstracts;
using SmartHouseManager.Realizer;

class Program
{
    static void Main(string[] args)
    {
       var lamp = new Lamp(new MobileAppManager());
       lamp.IncreaseVolume();
       lamp.TurnOff();
       lamp.TurnOn();
    }
}