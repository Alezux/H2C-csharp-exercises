using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_43
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                number = number * -1;
                Console.WriteLine(number);
            }

            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
