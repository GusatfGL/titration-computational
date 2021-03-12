using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 2, 4, 6, 7, 8, 34, 3, 5,3,3,6,7,23,12,5,2,34,6,11324,4,653,34,45};
            int[] sort = BubbleSort(array);

            for (int i=0;i<sort.Length;i++)
            {
                Console.WriteLine(sort[i]);
            }

            Console.ReadKey();

        }

        static int[] BubbleSort(int[] unsorted)
        {
            int[] sorted = unsorted;

            for (int x = 0; x < sorted.Length; x++)
            {
                for (int i = 0; i < sorted.Length - 1; i++)
                {
                    if (sorted[i] > sorted[i + 1])
                    {
                        int tmp = sorted[i + 1];
                        sorted[i + 1] = sorted[i];
                        sorted[i] = tmp;
                    }
                }
            }

            return sorted;
        }
    }
}
