using System;
class MultiThread
{
    static void Task1()
    {
        Console.WriteLine("Task 1 (Printing) started");
        for (int i = 1; i <=5; i++)
        {
            Console.WriteLine("Task 1: " + i);
            Thread.Sleep(2000);

        }
        Console.WriteLine("Task 1 Completed");
    }
    static void Task2()
    {
        Console.WriteLine("Task 2 (Computing) started");
        int sum = 0;
        for(int i = 1; i <= 1000000; i++)
        {
            sum+= i;
        }
        Console.WriteLine("Task 2 sum: " + sum);
        Console.WriteLine("Task 2 Completed");
    }
    static void Task3()
    {
        Console.WriteLine("Task 1 (Waiting) started");
        Thread.Sleep(1000);
        Console.WriteLine("Task 3 completed after wait");
    }
    static void Main()
    {
        Thread t1=new Thread(Task1);    
        Thread t2=new Thread(Task2);    
        Thread t3=new Thread(Task3);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();  
        t3.Join();

        Console.WriteLine("All task done");
    }
}