using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class World
    {
        private static int size = 50;
        private static Random rnd = new Random();
        private int[,] data = new int[size, size];
        private int[,] temp = new int[size, size]; 

        public void Init(double fertility)
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (fertility > rnd.NextDouble())
                        temp[x, y] = 1;
                    else
                        temp[x, y] = 0;
                }
            }
            data = temp;
        }

        public void InvasiveLife(int fertility)
        {
            for (int y = 1; y < size - 1; y++)
            {
                for (int x = 1; x < size - 1; x++) // Padding
                {
                    if (data[x,y] == 0)
                    {
                        if (fertility > rnd.Next(0, 101)) temp[x, y] = 1;
                    }
                }
            }
            data = temp;
        }

        public void NextGen()
        {
            for (int y = 1; y < size -1; y++)
            {
                for (int x = 1; x < size -1; x++) // Padding
                {
                    if (data[x,y] == 1)
                    {
                        if (GetNeighbours(x, y) == 2 || GetNeighbours(x, y) == 3) continue;
                        else
                        {
                            temp[x, y] = 0;
                        }
                    }
                    if (data[x,y] == 0)
                    {
                        if (GetNeighbours(x, y) == 3) temp[x, y] = 1;
                    }
                }
            }
            data = temp;
        }

        public void Plot()
        {
            Console.Clear();
            for (int y = 1; y < size - 1; y++)
            {
                for (int x = 1; x < size - 1; x++) // Padding
                {
                    if (data[x, y] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write("--");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("--");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
                Console.WriteLine();
            }
        }
        
        private int GetNeighbours(int xTarget, int yTarget)
        {
            int neighbours = 0;

            for (int y = yTarget-1; y <= yTarget+1; y++)
            {
                for (int x = xTarget-1; x <= xTarget+1; x++)
                {
                    if (x == xTarget && y == yTarget) continue;
                    if (data[x, y] == 1) neighbours++;
                }
            }

            return neighbours;
        }
    }
}
