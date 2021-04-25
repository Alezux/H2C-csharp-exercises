using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_52
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            PrintFromNumberToOne(9);
        }

        public static void PrintFromNumberToOne(int numOfTimes)
        {
            int i = 1;

            while (i <= numOfTimes)
            {
                Console.WriteLine(numOfTimes);
                numOfTimes--;

                if (i <= 0)
                {
                    return;
                }
            }
        }
    }
}
