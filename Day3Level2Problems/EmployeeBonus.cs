using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class EmployeeBonus
    {
        public static void calculate()
        {
            Console.WriteLine("Enter salary of 10 Employees :");
            double[] oldSalary = new double[10];
            double totalOldSalary = 0.0;
            double[] yearsOfService = new double[10];
            for (int i = 0; i < oldSalary.Length; ++i)
            {
                oldSalary[i] = int.Parse(Console.ReadLine());
                if (oldSalary[i] <= 0) { i--;Console.WriteLine("Invalid number try again"); continue; }
                totalOldSalary += oldSalary[i];
            }
            Console.WriteLine("Enter years of service of 10 Employees:");
            for (int i = 0; i < yearsOfService.Length; ++i)
            {
                yearsOfService[i] = int.Parse(Console.ReadLine());
                if (yearsOfService[i] <= 0) { i--; Console.WriteLine("Invalid number try again"); continue; }
            }
            double[] newSalary = new double[10];
            double[] bonus = new double[10];
            double totalNewSalary = 0.0;
            double totalBonus = 0.0;
            for(int i = 0; i < 10; ++i)
            {
                if (yearsOfService[i] > 5)
                {
                    bonus[i] = oldSalary[i] * 0.05;
                    newSalary[i] = oldSalary[i] + bonus[i];
                    totalNewSalary += newSalary[i];
                    totalBonus += bonus[i];
                }
                else
                {
                    bonus[i] = oldSalary[i] * 0.02;
                    newSalary[i] = oldSalary[i] + bonus[i];
                    totalNewSalary += newSalary[i];
                    totalBonus += bonus[i];
                }
                Console.WriteLine($"Adding a bonus of {bonus[i]} at {i}");
            }
            Console.WriteLine($"Total Bonus to be paid: {totalBonus:f}");
            Console.WriteLine($"Total Old salary: {totalOldSalary:f}");
            Console.WriteLine($"Total New salary: {totalNewSalary:f}");
        }
    }
}
