using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_66
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
                    var lastItem = list.Last();
                    Console.WriteLine(lastItem);
                    break;
                }

                list.Add(input);
            }
        }
    }
}
