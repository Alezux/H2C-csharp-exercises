using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_35
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            bool correct = false;

            while (!correct)
            {
                Console.WriteLine("Give a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 42)
                {
                    correct = true;
                }

                if (number != 42)
                {
                    correct = false;
                }

                if (correct)
                {
                    break;
                }
            }
        }
    }
}
