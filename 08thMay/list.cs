using System;
using System.Collections;
class Program
{
    static void Main()
    {
       
       //create a list of Inteere
       List<int>num = new List<int>();
       //Adding Element
       num.Add(1);
        num.Add(21);
        num.Add(15);

        //printin elements
        foreach(int n in num)Console.WriteLine(n);

    }
}