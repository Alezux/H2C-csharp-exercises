using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_26
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your age century:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 1900)
            {
                Console.WriteLine("You're very old.");
            }
        }
    }
}
