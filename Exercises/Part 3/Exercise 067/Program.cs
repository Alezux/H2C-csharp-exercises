using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_67
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
                    var firstItem = list.First();
                    var lastItem = list.Last();
                    Console.WriteLine(firstItem);
                    Console.WriteLine(lastItem);
                    break;
                }

                list.Add(input);
            }
        }
    }
}
