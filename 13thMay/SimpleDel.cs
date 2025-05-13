
/*
class SimpleDelegate
{
    public delegate int SomeOperator(int i, int j);

    class Program
    {
        static int Sum(int x, int y) { return x + y; }

        static void Main(string[] args)
        {
            SomeOperator add = Sum;

            int res = add(10, 10);

            Console.WriteLine(res);

        }
    }
}
*/

/*
class Function
{
    static int Sum(int x,int y) {  return x + y; }  
    static void Main(string[] args)
    {
        Func<int, int, int> add = Sum;
        int res = add(10, 20);
        Console.WriteLine(res);
    }
}
*/
class Action
{
    public static void Main()
    {
        Action<int> printActionDel = ConsolePrint;
        Action<int> printToPrinter = PrinterPrint;

        printActionDel(10);
        printToPrinter(45);
    }
    public static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
    }
    public static void PrinterPrint(int i) { Console.WriteLine("This is being printed to the Printer"); }
}