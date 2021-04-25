using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_71
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
                    Console.WriteLine("Search for?");
                    int number = Convert.ToInt32(Console.ReadLine());
                    var index = list.IndexOf(number);

                    if (list.Contains(number))
                    {
                        for (index = 0; index < list.Count; index++)
                        {
                            if (list[index] == number)
                            {
                                Console.WriteLine(number + " is at index " + index);
                            }
                        }
                    }

                    break;
                }

                list.Add(input);
            }
        }
    }
}
