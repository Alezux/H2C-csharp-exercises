using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_80
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 5, 1, 3, 4, 2 };
            int sum = SumOfNumbersInArray(numbers);
            Console.WriteLine(sum);
        }

        public static int SumOfNumbersInArray(int[] numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }
    }
}


