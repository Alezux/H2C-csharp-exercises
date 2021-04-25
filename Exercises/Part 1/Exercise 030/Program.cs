using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_30
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your percent [0 - 100]");
            int percent = Convert.ToInt32(Console.ReadLine());

            if (percent <= 0)
            {
                Console.WriteLine("Impossible");
            }

            if (percent > 0 && percent <= 50)
            {
                Console.WriteLine("Fail");
            }

            if (percent > 50 && percent <= 59)
            {
                Console.WriteLine("1");
            }

            if (percent > 59 && percent <= 69)
            {
                Console.WriteLine("2");
            }

            if (percent > 69 && percent <= 79)
            {
                Console.WriteLine("3");
            }

            if (percent > 79 && percent <= 89)
            {
                Console.WriteLine("4");
            }

            if (percent > 89 && percent <= 100)
            {
                Console.WriteLine("5");
            }

            if (percent > 100)
            {
                Console.WriteLine("Outstanding!");
            }
        }
    }
}
