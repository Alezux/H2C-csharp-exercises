using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_88
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
                var firstWord = sentence.Substring(0, sentence.IndexOf(" "));
                Console.WriteLine(firstWord);

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



