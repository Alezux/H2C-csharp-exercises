using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_81
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };
            PrintNeatly(array);
        }

        public static void PrintNeatly(int[] array)
        {
            Console.Write("{0}", string.Join(", ", array));
        }
    }
}

