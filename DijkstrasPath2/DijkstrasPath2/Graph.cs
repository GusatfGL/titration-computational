using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasPath2
{
    class Graph
    {
        public List<Node> Nodes = new List<Node>();

        public void AddNode(string name)
        {
            Nodes.Add(new Node(name));
        }

        public Graph()
        {

        }
    }
}
