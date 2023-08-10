using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x%2 == 0)
            {
                Console.WriteLine("Your number is even"); // if your condition is true, this block works
            }
            else
            {
                Console.WriteLine("Your number is odd"); // if your condition is false, this block works
            }

            Console.WriteLine("Enter an integer number:");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y > 0) {
                Console.WriteLine("Your entered number is positive");
            }
            else if (y < 0)
            {
                Console.WriteLine("Your entered number is negative");
            }
            else
            {
                Console.WriteLine("Your entered number is neutral");
            }
        }
    }
}

