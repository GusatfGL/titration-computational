using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        private static Random random = new Random();
        private static List<int> table = new List<int>();

        static void Main(string[] args)
        {

            for (int i = 0; i < 1000000; i++)
            {
                int sum = GetSum3Dice();
                table.Add(sum);
            }

            Console.WriteLine("Occurences of 3 (%): " + (decimal)GetOccurences(table, 3) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 4 (%): " + (decimal)GetOccurences(table, 4) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 5 (%): " + (decimal)GetOccurences(table, 5) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 6 (%): " + (decimal)GetOccurences(table, 6) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 7 (%): " + (decimal)GetOccurences(table, 7) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 8 (%): " + (decimal)GetOccurences(table, 8) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 9 (%): " + (decimal)GetOccurences(table, 9) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 10 (%): " + (decimal)GetOccurences(table, 10) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 11 (%): " + (decimal)GetOccurences(table, 11) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 12 (%): " + (decimal)GetOccurences(table, 12) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 13 (%): " + (decimal)GetOccurences(table, 13) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 14 (%): " + (decimal)GetOccurences(table, 14) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 15 (%): " + (decimal)GetOccurences(table, 15) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 16 (%): " + (decimal)GetOccurences(table, 16) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 17 (%): " + (decimal)GetOccurences(table, 17) / (decimal)table.Count * 100m);
            Console.WriteLine("Occurences of 18 (%): " + (decimal)GetOccurences(table, 18) / (decimal)table.Count * 100m);

            Console.ReadKey();
        }

        static int GetOccurences(List<int> list, int search)
        {
            int occurence = 0;
            foreach (int i in list)
            {
                if (search == i) occurence++; 
            }

            return occurence;
        }

        static int RollDice()
        {
            return random.Next(1, 7);
        }

        static int GetSum3Dice()
        {
            return RollDice() + RollDice() + RollDice();
        }
    }
}
