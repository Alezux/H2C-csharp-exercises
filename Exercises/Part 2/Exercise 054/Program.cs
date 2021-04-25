using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_54
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            DivisibleByThreeInRange(3, 12);
        }

        public static void DivisibleByThreeInRange(int beginning, int end)
        {
            int i = beginning;

            while (i <= end)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    i += 3;
                }
            }
        }
    }
}
