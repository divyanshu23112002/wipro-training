//power calculation
using System;

class PowerCalculator
{
    public int power(int baseval, int exponentval)
    {
        return (int)Math.Pow(baseval, exponentval);
    }


    public double power(double baseval, double exponentval)
    {
        return Math.Pow(baseval, exponentval);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PowerCalculator pc=new PowerCalculator();

        int res1 = pc.power(2, 3);

        Console.WriteLine("2^3 = "+res1);

        double res2 = pc.power(5.5, 2);
        Console.WriteLine("5.5^2 = " + res2);
    }
}