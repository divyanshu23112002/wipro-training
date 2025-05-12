using System;
public interface ICalculator
{
    int Add(int a,int b);
    int Sub(int a,int b);

    int Mul(int a,int b);
    int Div(int a,int b);
}
public class SimpleC : ICalculator
{
    public int Add(int a,int b)
    {
        return a + b;
    }
    public int Sub(int a, int b)
    {
        return a - b;
    }
    public int Mul(int a,int b)
    {
        return a * b;

    }
    public int Div(int a, int b)
    {
        return a / b;
    }
}
class Program
{
    static void Main()
    {
        SimpleC c = new SimpleC();

        Console.WriteLine("Add : "+c.Add(1,2));
        Console.WriteLine("Subtract : "+c.Sub(12,2));
        Console.WriteLine("Multiply : "+c.Mul(12,22));
        Console.WriteLine("Divide : " + c.Div(20, 4));
    }
}