using System;
public interface ITransport
{
    void Start();
    void Stop();
}
public class Bus:ITransport
{
    public void Start()
    {
        Console.WriteLine("Bus is Starting");
    }
    public void Stop()
    {
        Console.WriteLine("Bus is Stopping");
    }
}
public class Train:ITransport
{
    public void Start()
    {
        Console.WriteLine("Train is Starting");
    }
    public void Stop()
    {
        Console.WriteLine("Train is Stopping");
    }

}

class Program
{
    static void Main()
    {
        ITransport transport;
        transport = new Bus();
        transport.Start();
        transport.Stop();
        transport = new Train();
        transport.Start();
        transport.Stop();
    }
}