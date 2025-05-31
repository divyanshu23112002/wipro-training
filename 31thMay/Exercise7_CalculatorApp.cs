using System;

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static float Add(float a, float b) => a + b;
    public static double Add(double a, double b) => a + b;

    public static int Subtract(int a, int b) => a - b;
    public static float Subtract(float a, float b) => a - b;
    public static double Subtract(double a, double b) => a - b;

    public static int Multiply(int a, int b) => a * b;
    public static float Multiply(float a, float b) => a * b;
    public static double Multiply(double a, double b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose operation: Add, Subtract, Multiply");
        string operation = Console.ReadLine().ToLower();

        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
        {
            Console.WriteLine("Detected data type: int");
            switch (operation)
            {
                case "add":
                    Console.WriteLine("Result: " + Calculator.Add(int1, int2));
                    break;
                case "subtract":
                    Console.WriteLine("Result: " + Calculator.Subtract(int1, int2));
                    break;
                case "multiply":
                    Console.WriteLine("Result: " + Calculator.Multiply(int1, int2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        else if (float.TryParse(input1, out float float1) && float.TryParse(input2, out float float2))
        {
            Console.WriteLine("Detected data type: float");
            switch (operation)
            {
                case "add":
                    Console.WriteLine("Result: " + Calculator.Add(float1, float2));
                    break;
                case "subtract":
                    Console.WriteLine("Result: " + Calculator.Subtract(float1, float2));
                    break;
                case "multiply":
                    Console.WriteLine("Result: " + Calculator.Multiply(float1, float2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        else if (double.TryParse(input1, out double double1) && double.TryParse(input2, out double double2))
        {
            Console.WriteLine("Detected data type: double");
            switch (operation)
            {
                case "add":
                    Console.WriteLine("Result: " + Calculator.Add(double1, double2));
                    break;
                case "subtract":
                    Console.WriteLine("Result: " + Calculator.Subtract(double1, double2));
                    break;
                case "multiply":
                    Console.WriteLine("Result: " + Calculator.Multiply(double1, double2));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
    }
}