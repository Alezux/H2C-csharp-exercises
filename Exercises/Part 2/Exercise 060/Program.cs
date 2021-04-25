using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_60
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            PrintSquare(4);
            PrintRectangle(17, 3);
            PrintTriangle(4);
        }


        public static void PrintStars(int number)
        {
            int i = 1;

            while (i <= number)
            {
                Console.Write("*");
                i++;
            }

            Console.WriteLine("");
        }

        public static void PrintSquare(int size)
        {
            int i = 1;
            Console.WriteLine("");

            while (i <= size)
            {
                PrintStars(size);
                i++;
            }

            Console.WriteLine("");
        }

        public static void PrintRectangle(int width, int height)
        {
            int i = 1;

            while (i <= height)
            {
                PrintStars(width);
                i++;
            }
        }

        public static void PrintTriangle(int size)
        {
            int i, j;

            for (i = -1; i < size; i++)
            {
                for (j = -1; j < i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
