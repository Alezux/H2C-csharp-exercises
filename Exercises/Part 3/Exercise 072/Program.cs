using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_72
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

                if (input == 9999)
                {
                    var smallest = list.Min();
                    Console.WriteLine("Smallest number: " + smallest);
                    var index = list.IndexOf(smallest);

                    if (list.Contains(smallest))
                    {
                        for (index = 0; index < list.Count; index++)
                        {
                            if (list[index] == smallest)
                            {
                                Console.WriteLine(smallest + " is at index " + index);
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
