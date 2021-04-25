using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_89
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            bool boolean = false;

            while (!boolean)
            {
                string sentence = Console.ReadLine();
                string lastWord = sentence.Split(' ').Last();
                Console.WriteLine(lastWord);

                if (string.IsNullOrEmpty(sentence))
                {
                    boolean = true;
                }

                if (boolean)
                {
                    break;
                }
            }
        }
    }
}



