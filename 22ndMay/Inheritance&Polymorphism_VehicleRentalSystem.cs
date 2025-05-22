using System;
using System.Collections.Generic;
abstract class Vehicle
{
    public string VehicleNum {  get; set; }
    public string Brand {  get; set; }

    public double RatePerDay { get; set; }

    public Vehicle(string vehicleNum, string brand, double ratePerDay)
    {
        VehicleNum = vehicleNum;
        Brand = brand;
        RatePerDay = ratePerDay;
    }
    public virtual double CalcRent(int days)
    {
        return RatePerDay * days;
    }
    public virtual void ShowDetails()
    {
        Console.WriteLine($"Vehicle: {Brand}, Number: {VehicleNum}, Rate/Day: {RatePerDay}");
    }
}
class Car:Vehicle
{
    public Car(string vehicleNum,string brand,double ratePerDay):base(vehicleNum, brand, ratePerDay) { }
    public override double CalcRent(int days)
    {
        double baseRent=base.CalcRent(days);
        return baseRent+500;
    }
}
class Bike:Vehicle
{
    public Bike(string vehicleNum, string brand, double ratePerDay) : base(vehicleNum, brand, ratePerDay) { }
    public override double CalcRent(int days)
    {
        double baseRent = base.CalcRent(days);
        return baseRent + 100;
    }
}
class Truck : Vehicle
{
    public Truck(string vehicleNum, string brand, double ratePerDay) : base(vehicleNum, brand, ratePerDay) { }
    public override double CalcRent(int days)
    {
        double baseRent = base.CalcRent(days);
        return baseRent + 1000;
    }
}
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("BR338902","Toyota",1500),
            new Bike("BR016666","Hero",500),
            new Truck("BR091234","Tata",2500)
        };
        int rentDay = 5;
        foreach(Vehicle v in vehicles)
        {
            v.ShowDetails();
            Console.WriteLine($"Rent for {rentDay} days: Rs. {v.CalcRent(rentDay)}");
        }
    }
}