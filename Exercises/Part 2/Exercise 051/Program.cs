using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_51
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            PrintUntilNumber(5);
        }

        public static void PrintUntilNumber(int numOfTimes)
        {
            int i = 1;

            while (i <= numOfTimes)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
