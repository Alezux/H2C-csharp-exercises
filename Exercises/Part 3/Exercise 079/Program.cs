using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_79
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            array[0] = 6;
            array[1] = 2;
            array[2] = 8;
            array[3] = 1;
            array[4] = 3;
            array[5] = 0;
            array[6] = 9;
            array[7] = 7;

            Console.WriteLine("Search for?");
            int searching = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (searching == array[i])
                {
                    found = true;
                    Console.WriteLine(searching + " is at index " + i);
                }
            }

            if (!found)
            {
                Console.WriteLine(searching + " was not found.");
            }
        }
    }
}


