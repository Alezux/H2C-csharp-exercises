using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_16
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many days?");
            int days = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(days * 86400 + " seconds");
        }
    }
}
