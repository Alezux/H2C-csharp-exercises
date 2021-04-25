using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_92
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            bool boolean = false;
            int checkValue = 0;
            int checkValue2 = 0;
            string checkName = "";
            string checkYear = "";
            string name;
            string birthYear;
            var today = DateTime.Today;
            var age = 0;

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
                name = pieces[0].Trim();
                birthYear = pieces[1].Trim();

                if (pieces.Length == 2 && birthYear.Length == 4)
                {
                    if (checkValue < name.Length)
                    {
                        checkValue = name.Length;
                        checkName = name;
                    }

                    if (checkValue2 < birthYear.Length)
                    {
                        checkValue2 = birthYear.Length;
                        checkYear = birthYear;
                    }

                    age = today.Year - Convert.ToInt32(birthYear);
                }
            }

            Console.WriteLine("Longest name: " + checkName);
            Console.WriteLine("Highest age: " + age);
        }
    }
}



