using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstrasPath2
{
    /// <summary>
    /// Logic should be here, not entirely flawless relation between classes.
    /// </summary>
    public static class Logic
    {
        /// <summary>
        /// Starts everything
        /// </summary>
        public static void Init()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");

            graph.Nodes[0].AddVertex(graph.Nodes[1], 3);
        }
    }
}
