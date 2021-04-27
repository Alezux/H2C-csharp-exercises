using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_100
{
    //Valmis
    class Program
    {
        public static void Main(string[] args)
        {
            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.PrintBalance();
            mortgage.WaitOneYear();
            mortgage.PrintBalance();

            int years = 0;

            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }

            mortgage.PrintBalance();
        }
    }

    class Debt
    {
        double balance;
        double interestRate;

        public Debt(double initialBalance, double initialInterestRate)
        {
            this.balance = initialBalance;
            this.interestRate = initialInterestRate;
        }

        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }

        public void WaitOneYear()
        {
            balance = balance * interestRate;
        }
    }
}



