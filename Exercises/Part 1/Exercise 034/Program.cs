using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_34
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            bool correct = false;

            while (!correct)
            {
                Console.WriteLine("Do you want to continue?");
                string answer = Console.ReadLine();

                if (answer == "no")
                {
                    correct = true;
                }

                if (answer != "no")
                {
                    correct = false;
                }
            }
        }
    }
}
