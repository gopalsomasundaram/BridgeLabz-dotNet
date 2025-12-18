using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class VotingEligibility
    {
        public static void check()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18) Console.WriteLine("The person can vote");
            else Console.WriteLine("The person cannot vote");
        }
    }
}
