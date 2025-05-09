using ConsoleApp3;
using System;

class Program
{
    static void Main()
    {
        Calculator c=new Calculator();

        Console.WriteLine("Addition : ");
        Console.WriteLine("2+3 = " + c.Add(2, 3));
        Console.WriteLine("2.5+3.7= " + c.Add(2.5,3.7));
        Console.WriteLine("1+2+3= "+c.Add(1,2,3));

        Console.WriteLine("\nSubtraction : ");
        Console.WriteLine("10 - 3 = " + c.sub(10, 3));
        Console.WriteLine("20.6 - 5.3 = " + c.sub(20.6, 5.3));
        Console.WriteLine("65 - 30 -10 = " + c.sub(65, 30,10));

        Console.WriteLine("\nMultiplication : ");
        Console.WriteLine("3 x 5 = "+c.mul(3,5));
        Console.WriteLine("10.2 x 7.3 = " + c.mul(10.2, 7.3));
        Console.WriteLine("23.1 x 15.2 x 12.3 = " + c.mul(23.1, 15.2,12.3));



    }
}









using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b) { return a + b; }

        public int Add(int  a, int b, int c)
        {
            return a+b+c;
        }
        public int sub(int a,int b) {  return a - b; }
        public double sub(double a, double b) {return a - b; }

        public int sub(int a, int b, int c) { return a - b - c; }

        public int mul(int a,int b) { return a * b; }

        public double mul(double a,double b) { return a * b; }

        public double mul(double a,double b,double c) { return a * b * c; }
    }
}
