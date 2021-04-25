using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_70
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                {
                    var greatest = list.Max();
                    Console.WriteLine("Greatest number: " + greatest);
                    break;
                }

                list.Add(input);
            }
        }
    }
}
