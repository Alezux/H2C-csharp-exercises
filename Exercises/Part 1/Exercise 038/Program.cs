using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_38
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            int numbers = 0;
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                return;
            }

            Console.WriteLine("Give a number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 == 0)
            {
                return;
            }

            Console.WriteLine("Give a number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 == 0)
            {
                return;
            }

            Console.WriteLine("Give a number:");
            int number4 = Convert.ToInt32(Console.ReadLine());

            if (number4 == 0)
            {
                return;
            }

            if (number < 0)
            {
                numbers++;
            }


            if (number2 < 0)
            {
                numbers++;
            }


            if (number3 < 0)
            {
                numbers++;
            }


            if (number4 < 0)
            {
                numbers++;
            }

            Console.WriteLine("Total amount of negative numbers: " + numbers);
        }
    }
}
