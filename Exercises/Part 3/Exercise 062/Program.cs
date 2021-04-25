using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_62
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
                    break;
                }

                list.Add(input);
            }

            Console.WriteLine(list[2]);
        }
    }
}
