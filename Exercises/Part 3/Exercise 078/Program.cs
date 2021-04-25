using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_78
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 3;
            array[2] = 5;
            array[3] = 7;
            array[4] = 9;

            int index = 0;
            int index2 = 0;

            while (index < array.Length && index2 < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
                index2++;
            }

            Console.WriteLine("");

            Console.WriteLine("Give two indices to swap: ");
            index = Convert.ToInt32(Console.ReadLine());
            index2 = Convert.ToInt32(Console.ReadLine());
            int number = array[index];
            int number2 = array[index2];
            int temp = array[index];
            array[index] = array[index2];
            array[index2] = temp;

            Console.WriteLine("");
            index = 0;
            index2 = 0;

            while (index < array.Length && index2 < array.Length)
            {
                Console.WriteLine(array[index]);
                index++;
                index2++;
            }
        }
    }
}


