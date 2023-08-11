using System;
   
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //A method is a block of code which only runs when it is called.
            //Why use methods? To reuse code: define the code once, and use it many times.
        }

        #region method that returns no value, takes no parameters

        public void Method1()
        {
            Console.WriteLine("Hello");
        }

        #endregion

        #region method that returns no value, takes a parameter

        public void Method2(int x)
        {
            Console.WriteLine(x);
        }

        #endregion

        #region method that returns a value, takes no parameters

        public int Method3()
        {
            return 3;
        }

        #endregion

        #region method that returns a value, takes a parameter

        public int Method4(int x, int y)
        {
            return x + y;
        }

        #endregion

        
    }
}

