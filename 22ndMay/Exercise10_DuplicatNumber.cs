using System;
class Program
{
    static void Main()
    {
        List<int> num = new List<int>
       {
           1, 2, 3, 4, 5, 6, 7, 8, 1,2,1,4,1,6,7,3,8,7,3,10,11
       };
        var dup = num.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Duplicat Number: ");
        foreach (var n in dup)
        {
            Console.WriteLine(n);
        }
    }
}