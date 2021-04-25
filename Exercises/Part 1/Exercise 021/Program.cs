using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_21
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give the second number!");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double average = (number + number2) / 2;
            Console.WriteLine("The average is: " + average);
        }
    }
}
