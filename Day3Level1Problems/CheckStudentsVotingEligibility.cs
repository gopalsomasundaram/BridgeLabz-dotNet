using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class CheckStudentsVotingEligibility
    {
        public static void check()
        {
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                if (i < 0) { Console.WriteLine($"Invalid age {i}"); }
                else if (i < 18) { Console.WriteLine($"The student with the age {i} cannot vote."); }
                else { Console.WriteLine($"The student with the age {i} can vote."); }
            }
        }
    }
}
