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



            // while
            Console.Write("Please enter number: ");
            string xAsString = Console.ReadLine();
            int x = Convert.ToInt32(xAsString);

            while (x >= 0)
            {
                Console.WriteLine(x);

                // print all numbers from 1 to 100
                for (int i = 1; i <= x; i = i + 1)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                Console.Write("Please enter number: ");
                xAsString = Console.ReadLine();
                x = Convert.ToInt32(xAsString);
            }



            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
