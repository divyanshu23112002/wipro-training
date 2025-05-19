using System;
public abstract class SmartDevice
{
    public void ShowStatus()
    {
        Console.WriteLine("Device Status Active");
    }
    public abstract void TurnOn();
}
public interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}
public class SmartLight:SmartDevice,IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light turned On");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Light do not support volume control");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Light do not support volume control");
    }
}
public class SmartSpeaker:SmartDevice,IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Speaker turned On");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Volume Increased");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Volume Decreased");
    }
}
class Program
{
    static void Main()
    {
        SmartDevice device;
        IRemoteControl control;

        device= new SmartLight();
        control = (IRemoteControl)device;
        device.ShowStatus();
        device.TurnOn();
        control.IncreaseVolume();
        control.DecreaseVolume();

        Console.WriteLine();

        device=new SmartSpeaker();
        control=(IRemoteControl)device;
        device.ShowStatus();
        device.TurnOn();
        control.IncreaseVolume();
        control.DecreaseVolume();
    }
}