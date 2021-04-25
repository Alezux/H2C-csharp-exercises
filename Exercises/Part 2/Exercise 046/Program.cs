using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_46
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                number++;
                Console.WriteLine(number);


                if (number == 100)
                {
                    break;
                }
            }
        }
    }
}
