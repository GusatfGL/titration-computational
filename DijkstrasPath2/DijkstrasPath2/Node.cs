using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasPath2
{
    class Node
    {
        public List<Vertex> vertices = new List<Vertex>();
        public string Name = string.Empty;

        public Node(string name)
        {
            Name = name;
        }

        public void AddVertex(Node target, int weight)
        {
            i.vertices.Add(new Vertex(j, weight));
            j.vertices.Add(new Vertex(j, i, weight));
        }

    }
}
