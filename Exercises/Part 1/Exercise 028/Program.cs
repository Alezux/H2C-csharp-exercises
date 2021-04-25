using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_28
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You're under age!");
            }

            if (age > 18)
            {
                Console.WriteLine("You're an adult!");
            }
        }
    }
}
