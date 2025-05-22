using System;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();

    public virtual void Feed()
    {
        Console.WriteLine($"Feeding the animal: {Name}");
    }
}
public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion roars!");
    }
}

public class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Elephant trumpets!");
    }
}

public class Monkey : Animal
{
    public Monkey(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Monkey chatters!");
    }
}


public class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void PerformZooActivities()
    {
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Feed();
            Console.WriteLine();
        }
    }
}


class Program
{
    public static void Main()
    {
        Zoo zoo = new Zoo();

        zoo.AddAnimal(new Lion("Simba", 5));
        zoo.AddAnimal(new Elephant("Dumbo", 10));
        zoo.AddAnimal(new Monkey("George", 3));

        zoo.PerformZooActivities();
    }
}