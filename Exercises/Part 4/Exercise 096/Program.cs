using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_96
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Room room = new Room();
        }
    }

    class Room
    {
        private string code;
        private int sEats;

        public Room(string classCode, int numberOfSEats)
        {
            this.code = classCode;
            this.sEats = numberOfSEats;
        }
    }
}



