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

            int menu = 0;
            do
            {

                Console.Write("Please enter first number: ");
                string x1AsString = Console.ReadLine();
                int x;
                x = Convert.ToInt32(x1AsString);

                Console.Write("Please enter second number: ");
                string y1AsString = Console.ReadLine();
                int y;
                y = Convert.ToInt32(y1AsString);

                int option = 0;
                do
                {
                    // 1 +
                    // 2 -
                    // 3 *
                    // 4 /
                    // 5 %
                    // 6 Exit
                    Console.WriteLine("Enter your choice:");
                    Console.WriteLine("1. x + y");
                    Console.WriteLine("2. x - y");
                    Console.WriteLine("3. x * y");
                    Console.WriteLine("4. x / y");
                    Console.WriteLine("5. x % y");
                    string optAsString = Console.ReadLine();
                    option = Convert.ToInt32(optAsString);
                }
                while (option < 1 || option > 5);

                if (option == 1)
                {
                    Console.WriteLine(x + y);
                }
                else if (option == 2)
                {
                    Console.WriteLine(x - y);
                }
                else if (option == 3)
                {
                    Console.WriteLine(x * y);
                }
                else if (option == 4)
                {
                    Console.WriteLine(x / y);
                }
                else 
                {
                    Console.WriteLine(x % y);
                }

                do
                {
                    Console.WriteLine("Calc again?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    string optAsString = Console.ReadLine();
                    menu = Convert.ToInt32(optAsString);
                }
                while (menu < 1 || menu > 2);
            }
            while (menu == 1);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
