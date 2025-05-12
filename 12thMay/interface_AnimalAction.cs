using System;
public interface IAnimalActions
{
    void Eat();
    void Sleep();

}
public class Lion: IAnimalActions
{
    public void Eat()
    { 
        Console.WriteLine("Lion is eating meat");
    }
    public void Sleep()
    {
        Console.WriteLine("Lion is Sleeping");
    }
}
public class Elephant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }
    public void Sleep()
    {
        Console.WriteLine("Elephant is Sleeping");
    }
}

class Program
{
    static void Main()
    {
        IAnimalActions lion=new Lion();
        IAnimalActions elephant=new Elephant();

        lion.Eat();
        lion.Sleep();
        elephant.Eat();
        elephant.Sleep();

    }
}