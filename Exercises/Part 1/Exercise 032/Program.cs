using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_32
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Speak, friend, and enter!");
            string word = Console.ReadLine();

            if (word == "Mellon")
            {
                Console.WriteLine("Welcome, friend.");
            }

            else
            {
                Console.WriteLine("They've got a cave troll!");
            }
        }
    }
}
