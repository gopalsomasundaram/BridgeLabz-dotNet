using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Transactions;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class ZaraBonus
    {
        static double[,] GenerateSalaryAndYear()
        {
            Random random = new Random();
            double[,] SalaryAndYOS = new double[10, 2];
            for(int i = 0; i < 10; ++i)
            {
                SalaryAndYOS[i, 0] = random.Next(10000, 100000);
                SalaryAndYOS[i, 1] = random.Next(1, 10);
            }
            return SalaryAndYOS;
        }
        static double[,] CalcNewSalaryAndBonus(double[,] SalaryAndYOS)
        {
            double[,] NewSalaryAndBonus = new double[10, 2];
            for(int i = 0; i < 10; ++i)
            {
                double bonus;
                if (SalaryAndYOS[i, 1] > 5)
                {
                    bonus = (SalaryAndYOS[i, 0] * 0.05);
                    NewSalaryAndBonus[i, 1] = bonus;
                }
                else
                {
                    bonus = (SalaryAndYOS[i, 0] * 0.02);
                    NewSalaryAndBonus[i, 1] = bonus;
                }
                NewSalaryAndBonus[i, 0] = SalaryAndYOS[i, 0] + bonus;
            }
            return NewSalaryAndBonus;
        }
        static void DisplayData(double[,] SalaryAndYOS, double[,] NewSalaryAndBonus)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;
            Console.WriteLine($"{"Old Salary",12} {"New Salary",12} {"Bonus",12}");
            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"{SalaryAndYOS[i, 0],12:F} {NewSalaryAndBonus[i, 0],12:F} {NewSalaryAndBonus[i, 1],12:F}");
                totalBonus += NewSalaryAndBonus[i, 1];
                totalNewSalary += NewSalaryAndBonus[i, 0];
                totalOldSalary += SalaryAndYOS[i, 0];
            }
            Console.WriteLine($"Total Old Salary = {totalOldSalary:F}");
            Console.WriteLine($"Total New Salary = {totalNewSalary:F}");
            Console.WriteLine($"Total Bonus = {totalBonus:F}");
        }
        public static void Main()
        {
            double[,] SalaryAndYOS = GenerateSalaryAndYear();

            double[,] NewSalaryAndBonus = CalcNewSalaryAndBonus(SalaryAndYOS);

            DisplayData(SalaryAndYOS, NewSalaryAndBonus);
        }
    }
}
