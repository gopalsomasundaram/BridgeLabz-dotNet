using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class GradeChecking2D
    {
        public static void calc()
        {
            int n = int.Parse(Console.ReadLine());
            double[,] marks = new double[n, 3];
            double[] percentage = new double[n];
            char[] grade = new char[n];
            //for sum of MPC
            for (int i = 0; i < n; ++i)
            {
                marks[i, 0] = double.Parse(Console.ReadLine());//phy
                if (marks[i, 0] <= 0) { i--; Console.WriteLine("Invalid Input"); continue; }
                marks[i, 1] = double.Parse(Console.ReadLine());//chem
                if (marks[i, 1] <= 0) { i--; Console.WriteLine("Invalid Input"); continue; }
                marks[i, 2] = double.Parse(Console.ReadLine());//math
                if (marks[i, 2] <= 0) { i--; Console.WriteLine("Invalid Input"); continue; }
                percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;
                if (percentage[i] >= 80) grade[i] = 'A';
                else if (percentage[i] >= 70 && percentage[i] <= 79) grade[i] = 'B';
                else if (percentage[i] >= 60 && percentage[i] <= 69) grade[i] = 'C';
                else if (percentage[i] >= 50 && percentage[i] <= 59) grade[i] = 'D';
                else if (percentage[i] >= 40 && percentage[i] <= 49) grade[i] = 'E';
                else if (percentage[i] <= 39) grade[i] = 'R';
            }
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Physics Marks: {marks[i, 0]:f}, Chemistry Marks: {marks[i, 1]:f}, Math Marks: {marks[i, 2]:F} percentages: {percentage[i]:f}, Grade: {grade[i]}");
            }
        }
    }
}
