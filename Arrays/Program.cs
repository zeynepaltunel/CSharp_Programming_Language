using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] salaries = new double[5];
            
            //salaries[3] = 15000;
            //salaries[1] = 23000;

            ////Console.WriteLine(salaries[3]);

            //for (int i = 0; i < salaries.Length; i++)
            //{
            //    Console.WriteLine(salaries[i]);
            //}

            //string[] names = { "zeynep", "ayşe", "ali" };

            //for (int j = 0;  j < names.Length; j++)
            //{
            //    Console.WriteLine( (j+1) + ". name is " + names[j]);
            //}

            #region Array Class

            int[] numbers = new int[5];

            numbers[0] = 13;
            numbers[1] = 24;
            numbers[2] = 17;
            numbers[3] = 28;
            numbers[4] = 37;

            #region IsFixedSize

            /*  Property is used to get a get a value 
                indicating whether the Array has a fixed size. */

            Console.WriteLine(numbers.IsFixedSize);

            #endregion

            #region IsReadOnly

            //Declares whether the elements in the array are read-only

            Console.WriteLine(numbers.IsReadOnly);

            #endregion

            #region Length

            //It returns the length of the array

            Console.WriteLine(numbers.Length);

            #endregion

            #region Rank

            //It returns the length of the rank

            Console.WriteLine(numbers.Rank);

            #endregion

            #region Methods

            //Clear: defaults the value of the array's elements

            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("-------------");

            Array.Clear(numbers, 0, numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            //Copy

            //int[] numbers2 = new int[3];

            //for (int i = 0; i < numbers2.Length; i++) 
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //Array.Copy(numbers, numbers2 , 3);

            //Console.WriteLine("--------");

            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //IndexOf

            Console.WriteLine(Array.IndexOf(numbers, 35));

            //Reverse

            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("******");

            //Sort

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            #endregion

            #endregion

            }

        }
}
