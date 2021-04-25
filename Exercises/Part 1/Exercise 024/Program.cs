using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_24
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your speed:");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed < 125)
            {
                Console.WriteLine("Slow!");
            }

            if (speed > 125)
            {
                Console.WriteLine("Speeding!");
            }
        }
    }
}
