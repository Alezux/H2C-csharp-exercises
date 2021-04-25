using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_87
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
                string[] array = sentence.Split(new char[] { ' ', '\r', '\n', '\t' });

                foreach (string word in array)
                {
                    if (word.Contains("av"))
                    {
                        Console.WriteLine(word);
                    }
                }

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

