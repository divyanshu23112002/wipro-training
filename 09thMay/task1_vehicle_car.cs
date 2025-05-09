using System;

class Vehicle
{
    public string make;
    public string model;

    public void DisplayVehicle()
    {
        Console.WriteLine("Vehicle Make : "+make);
        Console.WriteLine("Vehicle Model : "+model);
    }
}

class Car: Vehicle
{
    public string fuelType;

    public void DisplayCar()
    {
        Console.WriteLine("Fuel Type : "+fuelType);     
    }
}

class Program
{
    static void Main()
    {
        Car myCar=new Car();
        myCar.make = "Hyundai";
        myCar.model = "Creta";
        myCar.fuelType = "Diesel";

        myCar.DisplayVehicle();
        myCar.DisplayCar();
    }
}