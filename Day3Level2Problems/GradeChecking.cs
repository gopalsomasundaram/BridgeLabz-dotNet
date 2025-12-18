using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class GradeChecking
    {
        public static void calc()
        {
            int n = int.Parse(Console.ReadLine());
            double[] marks = new double[n];
            double[] percentage = new double[n];
            char[] grade = new char[n];
            //for sum of MPC
            for(int i = 0; i < n; ++i)
            {
                double phy = double.Parse(Console.ReadLine());
                if (phy <= 0) { i--; Console.WriteLine("Invalid Input");continue; }
                double chem = double.Parse(Console.ReadLine());
                if (chem <= 0) { i--; Console.WriteLine("Invalid Input");continue; }
                double math = double.Parse(Console.ReadLine());
                if (math <= 0) { i--; Console.WriteLine("Invalid Input");continue; }
                marks[i] = phy + chem + math;
                percentage[i] = marks[i]/3;
                if (percentage[i] >= 80) grade[i] = 'A';
                else if (percentage[i] >= 70 && percentage[i] <= 79) grade[i] = 'B';
                else if (percentage[i] >= 60 && percentage[i] <= 69) grade[i] = 'C';
                else if (percentage[i] >= 50 && percentage[i] <= 59) grade[i] = 'D';
                else if (percentage[i] >= 40 && percentage[i] <= 49) grade[i] = 'E';
                else if (percentage[i] <= 39) grade[i] = 'R';

            }
            for(int i = 0; i < n; ++i)
            {
                Console.WriteLine($"Total Marks: {marks[i]:f}, percentages: {percentage[i]:f}, Grade: {grade[i]}");
            }
        }
    }
}
