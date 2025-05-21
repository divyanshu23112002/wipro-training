using System;
class Program
{
    static void TowerOfanoi(int n,char from,char to,char aux)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {from} to {to}");
            return;
        }
        TowerOfanoi(n-1,from,aux,to);
        Console.WriteLine($"Move disk {n} from {from} to {to}");
        TowerOfanoi(n-1,aux,to,from);   

    }
    static void Main()
    {
        int n = 3;
        TowerOfanoi(n, 'A', 'C', 'B');
    }
}