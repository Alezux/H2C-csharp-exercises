using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_33
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first string:");
            string word = Console.ReadLine();
            Console.WriteLine("Give the second string:");
            string word2 = Console.ReadLine();

            if (word == "Potato" && word2 == "Potato")
            {
                Console.WriteLine("Echo!");
            }

            else
            {
                Console.WriteLine("Nope!");
            }
        }
    }
}
