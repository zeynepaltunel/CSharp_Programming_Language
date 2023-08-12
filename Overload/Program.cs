using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.sum(2,3,4));
            Console.WriteLine(math.sum(5,7));
            Console.WriteLine(math.sum(12.2,23.2));
        }
    }
}
