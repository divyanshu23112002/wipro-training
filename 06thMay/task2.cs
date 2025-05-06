using System;
class Program
{
    static void Main()
    {
        int num = 1234;
        int sum = SumOfDigit(num);
        Console.WriteLine(sum);

    }
    static int SumOfDigit(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            int temp = num % 10;
            sum += temp;
            num /= 10;
        }
        return sum;
    }
}