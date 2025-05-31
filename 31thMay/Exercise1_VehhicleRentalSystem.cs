using System;
using System.Collections.Generic;

public interface IRentable
{
    decimal Rent(int days);
}

public class Vehicle
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public decimal RentPerDay { get; set; }

    public Vehicle(string model, string brand, decimal rentPerDay)
    {
        Model = model;
        Brand = brand;
        RentPerDay = rentPerDay;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"{Brand} {Model} - Rs.{RentPerDay}/day");
    }
}

public class Car : Vehicle, IRentable
{
    public Car(string model, string brand, decimal rentPerDay) : base(model, brand, rentPerDay) { }

    public decimal Rent(int days)
    {
        return RentPerDay * days;
    }
}

public class Bike : Vehicle, IRentable
{
    public Bike(string model, string brand, decimal rentPerDay) : base(model, brand, rentPerDay) { }

    public decimal Rent(int days)
    {
        return RentPerDay * days;
    }
}

public class Truck : Vehicle, IRentable
{
    public Truck(string model, string brand, decimal rentPerDay) : base(model, brand, rentPerDay) { }

    public decimal Rent(int days)
    {
        return RentPerDay * days;
    }
}

class Program
{
    static void Main()
    {
        List<IRentable> vehicles = new List<IRentable>
        {
            new Car("Swift", "Maruti", 1500),
            new Bike("Classic 350", "Royal Enfield", 700),
            new Truck("Ace", "Tata", 2500)
        };

        Console.WriteLine("Available Vehicles:");
        for (int i = 0; i < vehicles.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            ((Vehicle)vehicles[i]).DisplayInfo();
        }

        decimal totalRent = 0;
        while (true)
        {
            Console.Write("\nEnter vehicle number to rent (or 0 to exit): ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 0)
                break;

            if (choice < 1 || choice > vehicles.Count)
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            Console.Write("Enter number of days: ");
            int days = int.Parse(Console.ReadLine());

            IRentable selectedVehicle = vehicles[choice - 1];
            decimal cost = selectedVehicle.Rent(days);
            string vehicleType = selectedVehicle.GetType().Name;
            Console.WriteLine($"Rent for {vehicleType}: Rs. {cost}");
            totalRent += cost;
        }

        Console.WriteLine($"\nTotal Rent: Rs. {totalRent}");
    }
}