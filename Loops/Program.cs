using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            int num = 5;
            
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region While Loop

            int counter = 0;
            bool controller = true;
            while (controller)
            {
                Console.WriteLine("Zeynep");
                counter++;

                if(counter == 5)
                {
                    controller = false;
                }
            }
            #endregion

            #region Do While Loop

            Console.WriteLine("Is it rainy today?");
            bool isRain = Convert.ToBoolean(Console.ReadLine()); 

            do
            {
                Console.WriteLine("Take your umbrella");
                isRain = false;

            } while (isRain);

            #endregion

            #region ForEach Loop

            int[] numbers = { 23, 34, 32, 15, 78, 65, 47, 96 };

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
