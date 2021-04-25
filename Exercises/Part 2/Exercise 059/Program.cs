using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_59
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            int answer = Greatest(2, 7, 3);
            Console.WriteLine("Greatest: " + answer);
        }

        public static int Greatest(int number1, int number2, int number3)
        {
            return Math.Max(number1, Math.Max(number2, number3));
        }
    }
}
