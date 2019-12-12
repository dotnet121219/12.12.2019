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
            Console.Write("Please enter number: ");
            string xAsString = Console.ReadLine();
            int x = Convert.ToInt32(xAsString);

            if (x > 0)
            {
                Console.WriteLine("Positive!");
            }
            else if (x == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negaive!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
