﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_77
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> strings = new List<string>();

            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");

            strings.ForEach(Console.WriteLine);

            RemoveLast(strings);
            RemoveLast(strings);

            strings.ForEach(Console.WriteLine);
        }

        public static void RemoveLast(List<string> strings)
        {
            if (strings.Any())
            {
                strings.RemoveAt(strings.Count - 1);
            }
        }
    }
}


