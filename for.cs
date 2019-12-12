using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1212
{
    class Program
    {
        static void Main(string[] args)
        {
            // print all numbers from 1 to 100
            // for
            for (int i = 1; i <= 100; i = i * 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // while
            int j = 1;
            while (j <= 100)
            {
                Console.Write(j + " ");
                j = j + 1;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
