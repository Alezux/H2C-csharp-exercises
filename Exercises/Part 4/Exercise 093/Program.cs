using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_93
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Account", 100.0);

            account.Deposit(20);
            Console.WriteLine(account.balance);
        }
    }
}



