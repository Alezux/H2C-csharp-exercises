using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_15
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string strin = Console.ReadLine();
            Console.WriteLine("Give a integer:");
            int integer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give a double:");
            double dbl = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give a boolean:");
            bool boolean = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your string: " + strin);
            Console.WriteLine("Your integer: " + integer);
            Console.WriteLine("Your double: " + dbl);
            Console.WriteLine("Your boolean: " + boolean);
        }
    }
}
