using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_97
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Whistle duckWhistle = new Whistle("Kvaak");
            Whistle roosterWhistle = new Whistle("Peef");

            duckWhistle.Sound();
            roosterWhistle.Sound();
            duckWhistle.Sound();
        }
    }

    class Whistle
    {
        private string sound;

        public Whistle(string whistleSound)
        {
            this.sound = whistleSound;
        }

        public void Sound()
        {
            Console.WriteLine(sound);
        }
    }
}



