using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 1, 3, 5, 8, 22, 58, 61, 33, 44, 56, 101 };

            var odds = list.Where(num => num % 2 == 1);

            foreach (var oddNum in odds)
            {
                Console.WriteLine(oddNum);

            }
            Console.ReadKey();
        }
        
        //var list = new int[] { 3, 5, 8, 13, 21, 42, 61, 70, 87, 91 };

        //var odds =
        //             from num in list
        //             where num % 2 == 1
        //             select num;

        //foreach (var oddNum in odds)
        //{
        //    Console.WriteLine(oddNum);
        //}
        //Console.ReadKey();


    }
}
