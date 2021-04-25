using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_61
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            PrintRightTriangle(4);
            ChristmasTree(10);
        }

        public static void PrintStars(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        public static void PrintSpaces(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("");
            }
        }

        public static void PrintRightTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size - i; j++)
                {
                    Console.Write(" ");
                }

                PrintSpaces(size - i);
                PrintStars(i);
            }
        }

        public static void ChristmasTree(int height)
        {
            Console.WriteLine();
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 2; k <= i; k++)
                {
                    Console.Write("*");
                }

                PrintSpaces(height - i);
                PrintStars(i);
            }

            for (int l = 0; l < 1; l++)
            {
                for (int j = 3; j <= height; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= 2; k++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();

            for (int l = 0; l < 1; l++)
            {
                for (int j = 3; j <= height; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= 2; k++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}
