using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_84
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a word: ");
            string word = Convert.ToString(Console.ReadLine());
            
            if (word == "true")
            {
                Console.WriteLine("You got it right!");
            }

            else
            {
                Console.WriteLine("Try again!");
            }
        }
    }
}

