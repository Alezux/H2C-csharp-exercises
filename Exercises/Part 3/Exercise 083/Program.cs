using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_83
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a word: ");
            string word = Convert.ToString(Console.ReadLine());
            Console.WriteLine(word + word + word);
        }
    }
}

