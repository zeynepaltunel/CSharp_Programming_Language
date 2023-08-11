using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References
{
    class Program
    {
        static void Main(string[] args)
        {

            //Example example;
            //example = new Example();

            //Example example = new Example();

            Example x = new Example();
            Example y = x;

            if (x.Equals(y))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }

            Console.ReadKey(); 
        }
    }
}