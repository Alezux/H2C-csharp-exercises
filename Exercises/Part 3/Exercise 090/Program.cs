using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_90
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            bool boolean = false;
            int oldest = 0;
            string name = "";

            while (!boolean)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    boolean = true;
                }

                if (boolean)
                {
                    break;
                }

                string[] pieces = input.Split(",");
                int age = Convert.ToInt32(pieces[1]);

                if (age > oldest)
                {
                    name = pieces[0];
                    oldest = age;
                }
            }

            Console.WriteLine("Age of the oldest: " + oldest);
        }
    }
}



