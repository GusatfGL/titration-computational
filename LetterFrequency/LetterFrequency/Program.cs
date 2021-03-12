using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                    a++;
            }
            Console.WriteLine($"Frequency a: {a}");
            Console.ReadKey();
        }
        
        static void Ge
    }
}
