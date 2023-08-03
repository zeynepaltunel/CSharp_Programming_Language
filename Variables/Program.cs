using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comment
            //  Comment for one line
            /*
                Comment for more than one line
                ...
                ...
                ...
            */
            #endregion

            #region Variable Definition

            //string name;
            //int age;
            //char firstLetter;
            //bool isFull;

            #endregion

            #region Use of Variables

            //string name;
            //name = "Zeynep";
            //string lastName = "Altunel";
            //char firstLetter = 'A';

            //string country, city;
            //country = "Türkiye";
            //city = "İstanbul";

            //bool isSingle = true;

            #endregion

            #region Assigning Variables to Each Other

            int x = 5;
            int y = x; // y = 5

            int z = y + x; // z = 10

            y = y + 5; // y = 10

            #endregion

            #region Const

            const int k = 5;

            // k = 10 ERROR!

            #endregion

            #region Display Variables

            string name = "zeynep";
            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);

            #endregion

            #region Var Type

            /* 
                The var key allows us to define a variable without 
                specifying the type. The first value assigned to a variable
                defined with var determines the data type of the variable when
                the program is compiled.
             */

            var A = "ali"; // Now variable A is type string
            var B = 123; // Now variable A is type integer

            #endregion

            #region Object Type

            object obj1 = "";
            object obj2 = 123;

            //boxing
            
            object staff = "zeynep";

            //unboxing

            string firstName = (string)staff;
            Console.WriteLine(firstName);
            Console.ReadKey(true);
            #endregion

        }
    }
}
