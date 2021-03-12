using System;

namespace SandboxLineBreaking
{
    // Inspired by java https://www.programiz.com/dsa/bellman-ford-algorithm

    class Graph
    {
        public class Edge
        {
            public int From;
            public int Target;
            public int Weight;

            public Edge() // Hmm, could this be shortened by initizialisation
            {
                From = 0;
                Target = 0;
                Weight = 0;
            }

        }

        public int Nodes;
        public int Edges;

        public Edge[] AdjacencyList;

        public Graph(int v, int e)
        {
            Nodes = v;
            Edges = e;
            AdjacencyList = new Edge[e];
            for (int i = 0; i < e; ++i)
            {
                AdjacencyList[i] = new Edge();
            }
        }

        // Vad vill jag att denna ska returnera? en array med distanser? och varför vet den ej vägen?
        public void BellmanFord(Graph graph, int source) // s must be source, right?
        {
            int nodes = graph.Nodes;

            Edges = graph.Edges;

            int[] distance = new int[nodes];

            for (int i = 0; i < nodes; ++i)
            {
                distance[i] = int.MaxValue;
            }

            distance[source] = 0;

            for (int i = 1; i < nodes; ++i)
            {
                for (int j = 0; j < Edges; ++j)
                {
                    int u = graph.AdjacencyList[j].From;
                    int v = graph.AdjacencyList[j].Target;
                    int w = graph.AdjacencyList[j].Weight;

                    if (distance[u] != int.MaxValue && distance[u] + w < distance[v])
                    {
                        distance[v] = distance[u] + w;
                    }
                }
            }

            printSolution(distance, nodes);
        }

        public void printSolution(int[] dist, int V)
        {
            for (int i = 0; i < V; ++i)
            {
                Console.WriteLine(i + "\t\t" + dist[i]);
            }
        }
    }
}
