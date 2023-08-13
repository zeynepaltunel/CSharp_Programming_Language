using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example example = new Example();
            //Console.WriteLine(example.Name);
            //example.Name = "Test";
            //Console.WriteLine(example.Name);
            //example.Number = 1;

            new Example();
            new Example();
            new Example();
            new Example();
        }
    }

    class Example
    {
        #region Field

        //string x;

        #endregion

        #region Property

        //string name;
        //public string Name
        //{
        //    get 
        //    { 
        //        return name; 
        //    }

        //    set 
        //    { 
        //        name = value; 
        //    }
        //}

        //string x;

        // Ctrl + R + E

        //public string X { get => x; set => x=value; }

        #endregion

        #region Property 2

        //prop
        //public int Number { get; set; }

        #endregion

        #region Auto Property Initializers

        //public string Name { get; set; } = "Zeynep";

        #endregion

        #region Constructor

        //A constructor is a special method that is used to initialize objects.
        //Constructor method must be public.
        //Constructor method has no return value
        //Constructor method name must be same as class name

        public int X { get; set; }

        public Example() 
        {
            Console.WriteLine("Object created");
        }

        public void example1()
        {

        }

        #endregion

        #region Static Constructor

        /*  Runs before normal constructor.
            Triggered from the first of the object requests made
            from the related class, not from the next ones. */

        static Example()
        {
            Console.WriteLine("Worked before constructor");
        }

        #endregion
    }
}