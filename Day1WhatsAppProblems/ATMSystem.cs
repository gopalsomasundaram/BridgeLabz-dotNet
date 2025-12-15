using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class ATMSystem
    {
        public static void withdrawAmount() {
            Console.Write("Enter Amount to be withdrawn: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Current account balance: ");
            int accBalance = Convert.ToInt32(Console.ReadLine());
            if (amount < 20000)
            {
                if (amount < accBalance)
                {
                    if ((accBalance - amount) > 1000)
                    {
                        Console.WriteLine("Accepted");
                    }
                    else { Console.WriteLine("Rejected: Withdraw will lead to less account Balance than required minimum balance"); }
                }
                else { Console.WriteLine("Rejected: Amount is greater that account balance"); }
            }
            else { Console.WriteLine("Rejected: Amount is greater than daily limit"); }
        }
    }
}
