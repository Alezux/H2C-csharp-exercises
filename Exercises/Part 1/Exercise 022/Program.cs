using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_22
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
            Console.WriteLine("Give the third number!");
            double number3 = Convert.ToDouble(Console.ReadLine());
            double average = (number + number2 + number3) / 3;
            Console.WriteLine("The average is: " + average);
        }
    }
}
