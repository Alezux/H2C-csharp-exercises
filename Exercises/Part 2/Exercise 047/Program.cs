using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_47
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where to?");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where from?");
            int number2 = Convert.ToInt32(Console.ReadLine());

            while (number > number2)
            {
                number2++;
                Console.WriteLine(number2);

                if (number <= number2)
                {
                    number2--;
                    break;
                }
            }
        }
    }
}
