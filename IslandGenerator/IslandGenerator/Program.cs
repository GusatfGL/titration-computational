using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandGenerator
{
    class Program
    {
        static Island island = new Island(123);

        static void Main(string[] args)
        {
            island.Init();
            island.GiveLife(0.2);
            island.EvalNeighbours();
            island.DisplayIsland();
        }
    }
}
