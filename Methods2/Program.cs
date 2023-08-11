using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = isEven(23);
            Console.WriteLine(a);
        }

        static bool isEven(int num) {

            if (num%2 == 0) 
                return true;
            else
                return false;

        }
    }
}
