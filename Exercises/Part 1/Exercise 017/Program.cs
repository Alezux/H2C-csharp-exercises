using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_17
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int summation = number + number2;
            Console.WriteLine("The sum is: " + summation);
        }
    }
}
