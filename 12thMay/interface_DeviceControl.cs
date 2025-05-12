using System;

public interface IDeviceControl
{
    void TurnOn();
    void TurnOff();
}
public class SmartTV:IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("Smart TV is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("Smart TV is now OFF");
    }
}
public class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("Speaker is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("Speaker is now OFF");
    }
}
class Program
{
    static void Main()
    {
        IDeviceControl tv=new SmartTV();
        IDeviceControl speaker=new Speaker();

        tv.TurnOn();
        tv.TurnOff();

        speaker.TurnOn();
        speaker.TurnOff();

    }
}