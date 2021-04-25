using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_48
{
    //Valmis
    class Program
    {
        public static void Main(String[] args)
        {
            bool correct = false;
            double summation = 0;
            double numbers = 0;
            double average;
            int even = 0;
            int odd = 0;

            while (!correct)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number != -1)
                {
                    correct = false;
                }

                if (number == -1)
                {
                    correct = true;
                    summation -= number;
                    numbers--;
                }

                if (number % 2 == 0)
                {
                    even++;
                }

                else
                {
                    odd++;
                }

                summation += number;
                numbers++;
                average = summation / numbers;

                if (correct == true)
                {
                    Console.WriteLine("Thank you, bye!");
                    Console.WriteLine("The summation of numbers: " + summation);
                    Console.WriteLine("Total amount of numbers: " + numbers);
                    Console.WriteLine("The average of numbers: " + average);
                    Console.WriteLine("Total amount of even numbers: " + even);
                    Console.WriteLine("Total amount of odd numbers: " + odd);
                    break;
                }
            }
        }
    }
}
