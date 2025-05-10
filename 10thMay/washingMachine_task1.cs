//Application and WashinMachine

using System;

class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Operating Appliance");
    }
}
class WashingMachine:Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing Clothes");
    }
}

class Program
{
    static void Main()
    {
        Appliance a=new Appliance();
        a.Operate();

        Appliance wm=new Appliance();
        wm.Operate();
    }
}