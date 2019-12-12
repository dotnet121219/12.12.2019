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
            Console.Write("Please enter secret number: ");
            string secretAsString = Console.ReadLine();
            int secret = Convert.ToInt32(secretAsString);

            Console.Write("Please enter guess: ");
            string guessAsString = Console.ReadLine();
            int guess = Convert.ToInt32(guessAsString);

            int counter = 1;

            while (guess != secret)
            {
                if (guess > secret)
                {
                    Console.WriteLine("Guess lower...");
                }
                else
                {
                    Console.WriteLine("Guess higher...");
                }
                Console.Write("Please enter guess: ");
                guessAsString = Console.ReadLine();
                guess = Convert.ToInt32(guessAsString);

                counter++;
            }

            Console.WriteLine("Bingo ...");
            Console.WriteLine("it took you " + counter);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
