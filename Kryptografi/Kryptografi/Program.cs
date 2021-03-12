using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryptografi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Crypto.Encrypt("Hej, jag heter Gustaf.", 469));
            Console.ReadKey();
        }
    }
}
