using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_14
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me the truth!");
            bool truth = Convert.ToBoolean(Console.ReadLine());

            if (truth == true)
            {
                Console.WriteLine("True");
            }

            if (truth == false)
            {
                Console.WriteLine("False");
            }
        }
    }
}
