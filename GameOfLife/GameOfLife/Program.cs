using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            World w = new World();

            w.Init(0.05);
            w.Plot();

            Console.ReadKey();
            while(3==9/3)
            {
                w.Plot();

                string input = Console.ReadLine();
                string[] cmd = input.Split(' ');
                if (cmd[0] == "g")
                {
                    w.NextGen();
                    continue;
                }
                if (cmd[0] == "s")
                {
                    for (int i = 0; i < Convert.ToInt32(cmd[1]); i++)
                    {
                        w.NextGen();
                    }
                }
                if (cmd[0] == "invade")
                {
                    w.InvasiveLife(Convert.ToInt32(cmd[1]));
                }
            }
        }
    }
}
