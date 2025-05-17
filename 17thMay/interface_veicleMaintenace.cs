using System;
public interface IMaintenance
{
    void Service();
    void Repair();

}
public class CarMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}
public class BikeMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Bike is being repaired");
    }
}
class Program
{
    static void Main()
    {
        IMaintenance maintenance;
        maintenance = new CarMaintenance();
        maintenance.Service();
        maintenance.Repair();

        Console.WriteLine();

        maintenance = new BikeMaintenance();
        maintenance.Service();
        maintenance.Repair();

    }
}

