using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_27
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("It is positive.");
            }

            if (number < 0)
            {
                Console.WriteLine("It is negative.");
            }
        }
    }
}
