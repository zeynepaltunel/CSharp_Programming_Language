using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Type Conversions

            //string x = "123";
            //int y = Convert.ToInt32(x);
            //Console.WriteLine(y);

            //double a = 123.2;
            //string b = Convert.ToString(a);
            //Console.WriteLine(b);

            //bool x = true;
            //string y = Convert.ToString(x);
            //Console.WriteLine(y);

            //string z = "False";
            //bool t = Convert.ToBoolean(z);
            //Console.WriteLine(t);

            //-------------

            //Parse is only used when converting string type

            //string x = "123";
            //decimal y = decimal.Parse(x);
            //Console.WriteLine(y);

            //string a = "456";
            //int b = int. Parse(a);
            //Console.WriteLine(b);

            #endregion

            #region int-char Casting

            char a = 'F';
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);

            int x = 123;
            char y = Convert.ToChar(x);
            Console.WriteLine(y);

            //Console.WriteLine((int)'H');
            //Console.WriteLine((char)45);

            #endregion

            #region int-bool Casting

            bool isTrue = true;
            int z = Convert.ToInt32(isTrue);
            Console.WriteLine(z);

            int t = 0;
            bool isFalse = Convert.ToBoolean(t);
            Console.WriteLine(t);

            #endregion

            Console.Read();
        }
    }
}