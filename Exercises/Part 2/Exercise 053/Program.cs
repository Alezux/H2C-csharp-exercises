using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_53
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            Start();
        }

        public static void Start()
        {
            double first = 2;
            double second = 9;

            double division = Division(first, second);

            Console.WriteLine("Division: " + division);
        }

        public static double Division(double numerator, double denominator)
        {
            return denominator / numerator;
        }
    }
}
