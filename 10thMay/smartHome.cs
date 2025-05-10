//Smart Home

using System;

public class SmartDevice
{
    public string deviceName;
    public bool powerStatus;

    public void TogglePower()
    {
        powerStatus = !powerStatus;
        Console.WriteLine($"{deviceName} Power:{(powerStatus ? "ON" : "OFF")} ");
    }
}
public class SmartLight:SmartDevice
{
    public int brightness;
    public void SetBrightness(int value)
    {
        if(powerStatus)
        {
            brightness = value;
            Console.WriteLine($"{deviceName}Brightness set to : {brightness}");
        }
        else
        {
            Console.WriteLine($"{deviceName}is OFF cannot change Brightness");
        }
    }
}
public class SmartThermo:SmartDevice
{
    public double Temperature;
    public void SetTemp(double t)
    {
        if(powerStatus)
        {
            Temperature = t;
            Console.WriteLine($"{deviceName}Temperature set to : {Temperature} Celsius");
        }
        else
        {
            Console.WriteLine($"{deviceName}is OFF cannot set");
        }
    }
}
public class Program
{
    public static void Main()
    {
        SmartLight light = new SmartLight { deviceName = "Living Romm Light" };
        SmartThermo thermo = new SmartThermo { deviceName = "Hall Thermostat" };

        light.TogglePower();
        light.SetBrightness(80);

        thermo.TogglePower();
        thermo.SetTemp(30.5);

        light.TogglePower();
        light.SetBrightness(90);
    }
}