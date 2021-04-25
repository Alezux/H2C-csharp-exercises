using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_58
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            int answer = Smallest(2, 7);
            Console.WriteLine("Smallest: " + answer);
        }

        public static int Smallest(int number1, int number2)
        {
            return Math.Min(number1, number2);
        }
    }
}
