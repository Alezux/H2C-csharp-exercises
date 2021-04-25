using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_44
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number > number2)
            {
                Console.WriteLine(number + " is greater than " + number2 + ".");
            }

            if (number < number2)
            {
                Console.WriteLine(number + " is less than " + number2 + ".");
            }

            else
            {
                Console.WriteLine(number + " is equal to " + number2 + ".");
            }
        }
    }
}
