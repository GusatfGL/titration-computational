using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Genpop
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            List<int> frequencyRed = new List<int>();
            List<int> frequencyBlack = new List<int>();

            for (int iter = 0; iter < 1; iter++)
            {
                List<int> balls = new List<int>();
                List<int> survivors = new List<int>();

                //Console.WriteLine("There are 120 red alleles (1)");
                //Console.WriteLine("There are 80 black alleles (2)");

                for (int i = 0; i < 120; i++)
                {
                    balls.Add(1);
                }
                for (int i = 0; i < 80; i++)
                {
                    balls.Add(2);
                }

                //Console.WriteLine(balls.Count);

                for (int i = 0; i < 10; i++)
                {
                    int index = rnd.Next(0, balls.Count);
                    survivors.Add(balls[index]);
                    balls.RemoveAt(index);
                }

                for (int i = 0; i < survivors.Count; i++)
                {
                    //Console.WriteLine(survivors[i]);
                }
                //Console.WriteLine("Amount of black: " + GetAmountOf(survivors, 2));
                frequencyBlack.Add((int)GetAmountOf(survivors, 2));
                //Console.WriteLine("Amount of red: " + GetAmountOf(survivors, 1));
                frequencyRed.Add((int)GetAmountOf(survivors, 1));
                Console.WriteLine(iter);
                //Console.WriteLine("Proportions" + GetAmountOf(survivors, 1) / GetAmountOf(survivors, 2));
            }

            Console.WriteLine("list red avg: " + frequencyRed.Average());
            Console.WriteLine("list red 0:" + GetAmountOf(frequencyRed, 0) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 1:" + GetAmountOf(frequencyRed, 1) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 2:" + GetAmountOf(frequencyRed, 2) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 3:" + GetAmountOf(frequencyRed, 3) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 4:" + GetAmountOf(frequencyRed, 4) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 5:" + GetAmountOf(frequencyRed, 5) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 6:" + GetAmountOf(frequencyRed, 6) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 7:" + GetAmountOf(frequencyRed, 7) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 8:" + GetAmountOf(frequencyRed, 8) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 9:" + GetAmountOf(frequencyRed, 9) / Convert.ToDecimal(frequencyRed.Count));
            Console.WriteLine("list red 10:" + GetAmountOf(frequencyRed, 10) / Convert.ToDecimal(frequencyRed.Count));

            Console.WriteLine("list black 0:" + GetAmountOf(frequencyBlack, 0) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 1:" + GetAmountOf(frequencyBlack, 1) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 2:" + GetAmountOf(frequencyBlack, 2) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 3:" + GetAmountOf(frequencyBlack, 3) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 4:" + GetAmountOf(frequencyBlack, 4) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 5:" + GetAmountOf(frequencyBlack, 5) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 6:" + GetAmountOf(frequencyBlack, 6) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 7:" + GetAmountOf(frequencyBlack, 7) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 8:" + GetAmountOf(frequencyBlack, 8) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 9:" + GetAmountOf(frequencyBlack, 9) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black 10:" + GetAmountOf(frequencyBlack, 10) / Convert.ToDecimal(frequencyBlack.Count));
            Console.WriteLine("list black avg: " + frequencyBlack.Average());

            Console.ReadKey();

        }

        static decimal GetAmountOf(List<int> list, int value)
        {
            int temp = 0;
            foreach (int i in list)
            {
                if (i == value) temp++;
            }
            return Convert.ToDecimal(temp);
        }
    }
}
