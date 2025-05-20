using System;
//using System.Collections.Generic; 

class Program
{
    static void Dijkstra(int[,] graph, int src, out int[] dist, out int[] prev)
    {
        int n = graph.GetLength(0);
        dist = new int[n];
        bool[] visited = new bool[n];
        prev = new int[n];
        for (int i = 0; i < n; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            prev[i] = -1;
        }

      
        dist[src] = 0;

        
        for (int count = 0; count < n - 1; count++)
        {
            
            int u = -1;
            int minDist = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && dist[i] < minDist)
                {
                    minDist = dist[i];
                    u = i;
                }
            }
            if (u == -1) break;

            
            visited[u] = true;

            
            for (int v = 0; v < n; v++)
            {
               
                if (!visited[v] && graph[u, v] != 0 &&
                    dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    prev[v] = u;  
                }
            }
        }
    }

    static void Main(string[] args)
    {
      
        Console.Write("Enter number of vertices: ");
        int n = int.Parse(Console.ReadLine());
        int[,] graph = new int[n, n];
        Console.WriteLine("Enter adjacency matrix (0 for no edge):");
        for (int i = 0; i < n; i++)
        {
           
            string[] tokens = Console.ReadLine()
                                     .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < n; j++)
            {
                graph[i, j] = int.Parse(tokens[j]);
            }
        }

        Console.Write("Enter source vertex (0 to {0}): ", n - 1);
        int src = int.Parse(Console.ReadLine());
        Dijkstra(graph, src, out int[] dist, out int[] prev);

       
        Console.WriteLine("\nVertex\tDistance\tPath from {0}", src);
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}\t", i);

            
            if (dist[i] == int.MaxValue)
            {
                Console.Write("INF\t\tN/A");
                Console.WriteLine();
                continue;
            }

            Console.Write("{0}\t\t", dist[i]);

           
            Stack<int> pathStack = new Stack<int>();
            int current = i;
            while (current != -1)
            {
                pathStack.Push(current);
                current = prev[current];
            }
            
            while (pathStack.Count > 0)
            {
                Console.Write(pathStack.Pop());
                if (pathStack.Count > 0)
                    Console.Write(" -> ");
            }
            Console.WriteLine();
        }
    }
}