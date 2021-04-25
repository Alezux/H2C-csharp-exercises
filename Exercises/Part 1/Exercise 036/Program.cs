using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_36
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                return;
            }

            if (number < 0)
            {
                Console.WriteLine("That is negative.");
            }


            if (number > 0)
            {
                int multi = number * number;
                Console.WriteLine(multi);
            }

            Console.WriteLine("Give a number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 == 0)
            {
                return;
            }

            if (number2 < 0)
            {
                Console.WriteLine("That is negative.");
            }


            if (number2 > 0)
            {
                int multi = number2 * number2;
                Console.WriteLine(multi);
            }

            Console.WriteLine("Give a number:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 == 0)
            {
                return;
            }

            if (number3 < 0)
            {
                Console.WriteLine("That is negative.");
            }


            if (number3 > 0)
            {
                int multi = number3 * number3;
                Console.WriteLine(multi);
            }

            Console.WriteLine("Give a number:");
            int number4 = Convert.ToInt32(Console.ReadLine());

            if (number4 == 0)
            {
                return;
            }

            if (number4 < 0)
            {
                Console.WriteLine("That is negative.");
            }

            if (number4 > 0)
            {
                int multi = number4 * number4;
                Console.WriteLine(multi);
            }
        }
    }
}
