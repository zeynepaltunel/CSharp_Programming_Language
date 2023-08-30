using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedVsFinalClass
{
    class Program
    {
        sealed class Class2
        {
            
        }
        class Class1 : Class2
        {
            
        }

        //in c#, there is no keyword like 'final'.

        static void Main(string[] args)
        {

        }
    }
}