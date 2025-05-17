using System;
public abstract class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
    public abstract void MakeSound();
}
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Barks");
    }
}
public class Cat:Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meows");
    }
}
class Program
{
    static void Main()
    {
        Animal animal;
        animal=new Dog();
        animal.Eat();
        animal.MakeSound();

        Console.WriteLine();

        animal=new Cat();
        animal.Eat();
        animal.MakeSound(); 
        
    }
}