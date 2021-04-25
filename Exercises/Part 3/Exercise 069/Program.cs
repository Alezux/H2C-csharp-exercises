using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_69
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
                    list.Sort();

                    Console.WriteLine("From where?");
                    int number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Where to?");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    foreach (var listNums in list)
                    {
                        if (number < number2 && listNums <= number2)
                        {
                            Console.WriteLine(listNums);
                        }
                    }

                    break;
                }

                list.Add(input);
            }
        }
    }
}
