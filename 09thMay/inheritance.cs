using System;

class Animal
{
    public string Name;
    public string species;

    public void displayAnimal()
    {
        Console.WriteLine($"Animal Name : {Name}");
        Console.WriteLine($"Species : {species}");
    }

    class Dog : Animal
    {
        public string breed;

        public void displayDog()
        {
            Console.WriteLine($"Breed : {breed}");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog myDog = new Dog();
            myDog.Name = "Buddy";
            myDog.species = "Canine";
            myDog.breed = "Labrador";

            myDog.displayAnimal();

            myDog.displayDog();
        }
    }
}