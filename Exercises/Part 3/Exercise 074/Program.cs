using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_74
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    Console.WriteLine("Search for?");
                    string name = Convert.ToString(Console.ReadLine());

                    if (list.Contains(name))
                    {
                        Console.WriteLine(name + " was found!");
                    }

                    else
                    {
                        Console.WriteLine(name + " was not found!");
                    }

                    break;
                }

                list.Add(input);
            }
        }
    }
}

