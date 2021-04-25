using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_65
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
                    Console.WriteLine("Count: {0}", list.Count);
                    break;
                }

                list.Add(input);
            }
        }
    }
}
