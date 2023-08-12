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
            Example example = new Example();
            Console.WriteLine(example.Name);
            example.Name = "Test";
            Console.WriteLine(example.Name);
            example.Number = 1;
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

        string x;

        // Ctrl + R + E

        public string X { get => x; set => x=value; }

        #endregion

        #region Property 2

        //prop
        public int Number { get; set; }

        #endregion

        #region Auto Propert Initializers

        public string Name { get; set; } = "Zeynep";

        #endregion

        #region Constructor


        #endregion

        #region Static Constructor

        #endregion
    }
}