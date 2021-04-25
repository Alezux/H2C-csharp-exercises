using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_20
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
            int multi = number * number2;
            Console.WriteLine(number + " * " + number2 + " = " + multi);
        }
    }
}
