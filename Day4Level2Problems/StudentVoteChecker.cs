using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppTest.Day4Level2Problems
{
    public class StudentVoteChecker
    {
        public bool CanStudentVote(int age)
        {
            if(age<= 0) { return false; }
            if(age>=18) { return true; }
            else { return false; }
        }
        public static void Main()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter the age of 10 students:");
            for(int i = 0; i < 10; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            var obj = new StudentVoteChecker();
            foreach(int i in arr)
            {
                if (obj.CanStudentVote(i))
                {
                    Console.WriteLine($"Student of age {i} can vote");
                }
                else
                {
                    Console.WriteLine($"Student of age {i} cannot vote");
                }
            }

        }
    }
}
