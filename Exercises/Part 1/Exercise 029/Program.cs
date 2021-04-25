using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_29
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number > number2)
            {
                Console.WriteLine("The larger number is " + number + "!");
            }

            if (number < number2)
            {
                Console.WriteLine("The larger number is " + number2 + "!");
            }

            if (number == number2)
            {
                Console.WriteLine("They are equal!");
            }
        }
    }
}
