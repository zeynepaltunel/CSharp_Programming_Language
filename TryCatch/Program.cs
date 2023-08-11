using System;

namespace TryCatch
{
    class Program
    {

        private static int sum(int a, int b)
        {

            return a + b;
        }


        static void Main(string[] args)
        {
            #region compile error

            // int a = "123"; 

            #endregion

            #region logical error

            // you want to type 5 but let's say you typed 3
            // int x = 3;

            #endregion

            #region runtime error

            //Console.WriteLine("Enter  an integer number: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            // if you enter a decimal number you will get a runtime error.

            #endregion

            try
            {
                Console.Write("Enter first number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int y = Convert.ToInt32(Console.ReadLine());
                int a = sum(x, y);
                Console.WriteLine(a);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This block always works");
            }

        }
    }
}
