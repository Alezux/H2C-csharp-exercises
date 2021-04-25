using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_50
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many times?");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                PrintPhrase();
                number--;
            }
        }

        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }
    }
}
