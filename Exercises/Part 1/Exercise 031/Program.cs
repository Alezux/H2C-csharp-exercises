using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_31
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("It is even.");
            }

            else
            {
                Console.WriteLine("It is odd.");
            }
        }
    }
}
