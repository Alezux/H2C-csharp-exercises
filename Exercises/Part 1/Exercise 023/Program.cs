using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_23
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
            double summation = number + number2;
            double difference = number - number2;
            double multi = number * number2;
            double division = number / number2;
            Console.WriteLine(number + " + " + number2 + " = " + summation);
            Console.WriteLine(number + " - " + number2 + " = " + difference);
            Console.WriteLine(number + " * " + number2 + " = " + multi);
            Console.WriteLine(number + " / " + number2 + " = " + division);
        }
    }
}
