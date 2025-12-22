using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class CalcMarks
    {
        static double[,] GenerateMarks(int n)
        {
            Random random = new Random();
            double[,] marks = new double[n, 3];
            for(int i = 0; i < n; ++i)
            {
                marks[i, 0] = random.Next(10,100);//physics
                marks[i, 1] = random.Next(10, 100);//chem
                marks[i, 2] = random.Next(10, 100);//math
            }
            return marks;
        }
        static double[,] CalcResults(double[,] marks,int n)
        {
            double[,] results = new double[n, 3];
            for(int i = 0; i < n; ++i)
            {
                double total = Math.Round((marks[i, 0] + marks[i,1] + marks[i,2]),2);
                double average = Math.Round(total / 3,2);
                results[i, 0] = total;
                results[i, 1] = average;
                results[i, 2] = average;
            }
            return results;
        }
        static void DisplayData(double[,] marks, double[,] results, int n)
        {
            Console.WriteLine($"{"Physics",10} {"Chemistry",10} {"Math",10} {"Total",10} {"Average",10} {"Percentage",10}");
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine($"{marks[i,0],10:F} {marks[i, 1],10:F} {marks[i, 2],10:F} {results[i,0],10:F} {results[i,1],10} {"%"+results[i,2],10:F}");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter the number of students:");
            int n = int.Parse(Console.ReadLine());
            var marks = GenerateMarks(n);
            var results = CalcResults(marks, n);
            DisplayData(marks, results, n);
        }
    }
}
