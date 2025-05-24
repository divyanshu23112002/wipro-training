using System;
using System.Threading.Tasks;
class TaskWhen
{
    static async Task<string>RunTask(string name,int delay)
    {
        await Task.Delay(delay);
        return $"{name} completed";
    }
    static async Task Main()
    {

        Task<string> t1 = RunTask("Task A", 3000);
        Task<string> t2 = RunTask("Task B", 2000);
        Task<string> t3= RunTask("Task C", 1000);

        Task<string>first=await Task.WhenAny(t1, t2, t3);

     

        Console.WriteLine($"First completed: {first.Result}");
       

    }
}