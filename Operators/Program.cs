using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arithmetic Operators

            //int x = 10;
            //int y = 20;

            //int result1 = x + y;
            //int result2 = x - y;
            //int result3 = y / x;
            //int result4 = x * y;

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Console.WriteLine(result3);
            //Console.WriteLine(result4);

            //x++;
            //y--;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //int z = y%3;
            //Console.WriteLine(z);

            #endregion

            #region Comparison Operators

            //int x = 5;
            //int y = 10;
            //int z = 10;

            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(y == z);
            //Console.WriteLine(z >= x);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(y != x);

            #endregion

            #region Logical Operators

            // && and operator
            // || or operator
            // ! not operator

            int x = 0;
            int y = 5;

            Console.WriteLine(x < 5 &&  y < 10);
            Console.WriteLine(x < 0 || y < 4);

            // true && true = true
            // true && false = false
            // false && false = false

            // true || true = true
            // true || false = true
            // false || false = false


            #endregion

            Console.Read();
        }
    }
}
