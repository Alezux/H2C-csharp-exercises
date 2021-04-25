using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_10
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\nGive a name for main character: ");
            string name = Console.ReadLine();
            Console.WriteLine("Give the character a profession: ");
            string profession = Console.ReadLine();
            Console.WriteLine("Here is the story: \n" +
                "Once upon a time there was a " + profession + " called " + name + ".\n" +
                "On way to work, " + name + " often wondered what being " + profession + " meant to them." + "\n" +
                "When you work as a " + profession + ", you meet interesting people." + "\n" +
                name + " enjoys their work as " + profession + ", the end.");
        }
    }
}
