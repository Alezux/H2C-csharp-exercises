using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_39
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

            int summation = number + number2 + number3 + number4;
            Console.WriteLine("Total summation of numbers: " + summation);
        }
    }
}
