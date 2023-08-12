using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    public class Math
    {
        /* Multiple methods can have the same name with
           different parameters with method overloading. */

        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public double sum(double a, double b) 
        { 
            return a + b; 
        }

    }
}
