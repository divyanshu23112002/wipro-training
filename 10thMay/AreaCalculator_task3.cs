//Area Calculator

using System;
class AreaCalculator
{
    public double Area(double l,double b)
    {
        return l * b;   
    }
    public double Area(double r)
    {
        return r * r*Math.PI;
    }

    public double Area(float b,float h)
    {
        return 0.5*b*h;
    }
}

class Program
{
    static void Main(string[] args)
    {
        AreaCalculator ac=new AreaCalculator();

        double rectangle = ac.Area(10.0, 5.0);
       double traingle = ac.Area(6f, 4f);
        double circle = ac.Area(7.0);

        Console.WriteLine("Area of Rectangle : " + rectangle);
        Console.WriteLine("\nArea of Triangle : " + traingle);
        Console.WriteLine("\nArea of Circle : "+circle);
          


    }
}