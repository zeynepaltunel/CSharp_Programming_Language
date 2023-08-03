using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            switch (x)
            {
                case 1:
                    Console.WriteLine("Result is 1");
                    break;
                case 2:
                    Console.WriteLine("Result is 2");
                    break;
                case 3:
                    Console.WriteLine("Result is 3");
                    break;
                default: 
                    Console.WriteLine("There is no result");
                    break;
            }
        }
    }
}