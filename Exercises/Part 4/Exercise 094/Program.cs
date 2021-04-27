using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_94
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Account heikkisAccount = new Account("Heikki's account", 1000.0);
            Account heikkisPersonalAccount = new Account("Heikki's Personal account", 0);

            heikkisAccount.Withdrawal(100.0);
            heikkisPersonalAccount.Deposit(100.0);

            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisPersonalAccount);
        }
    }
}



