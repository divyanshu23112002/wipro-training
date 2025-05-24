using System;
using System.Threading.Tasks;
class AsyncException
{
    static async Task<string> RiskyTask(string name)
    {
        await Task.Delay(500);
        if(name=="Task B")
        {
            throw new Exception($"{name} faled due to an error");
        }
        return $"{name} completed Successfully";
    }
    static async Task Main()
    {

        Task<string> t1 = RiskyTask("Task A");
        Task<string> t2 = RiskyTask("Task B");
        Task<string> t3 = RiskyTask("Task C");

        try
        {
            string[] res = await Task.WhenAll(t1, t2, t3);
            foreach(var r in res)
            {
                Console.WriteLine(r);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");

            if (t1.IsFaulted) Console.WriteLine("Task A Failed.");
            if (t2.IsFaulted) Console.WriteLine("Task B Failed.");
            if (t3.IsFaulted) Console.WriteLine("Task C Failed.");
        }


    }
}