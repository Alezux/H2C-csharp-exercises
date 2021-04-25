using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_42
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number + number2;
            double squareRoot = Math.Sqrt(sum);
            Console.WriteLine(squareRoot);
        }
    }
}
