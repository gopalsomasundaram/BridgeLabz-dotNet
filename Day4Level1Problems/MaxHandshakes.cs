using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class MaxHandshakes
    {
        int CalculateMaxHandshakes(int numberOfStudents)
        {
            return ((numberOfStudents * (numberOfStudents - 1)) / 2);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) { Console.WriteLine("Invalid Input");return; }
            var obj = new MaxHandshakes();
            int totalHandshakes = obj.CalculateMaxHandshakes(n);
            Console.WriteLine($"Total number of handshakes: {totalHandshakes}");
        }
    }
}
