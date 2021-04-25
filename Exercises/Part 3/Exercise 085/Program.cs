using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_85
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string username = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter password: ");
            string password = Convert.ToString(Console.ReadLine());

            if (username == "alex" && password == "sunshine")
            {
                Console.WriteLine("You have successfully logged in!");
                return;
            }

            if (username == "emma" && password == "haskell")
            {
                Console.WriteLine("You have successfully logged in!");
                return;
            }

            else
            {
                Console.WriteLine("Incorrect username or password!");
            }
        }
    }
}

