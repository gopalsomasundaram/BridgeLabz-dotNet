using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class BMIStatus2D
    {
        public static void calc()
        {
            int n = int.Parse(Console.ReadLine());
            double[,] PersonData = new double[n,3];
            string[] status = new string[n];
            Console.WriteLine("Enter weight:");
            for (int i = 0; i < n; ++i)
            {
                PersonData[i,0] = double.Parse(Console.ReadLine());//weight arr
            }
            Console.WriteLine("Enter height:");
            for (int i = 0; i < n; ++i)
            {
                PersonData[i,1] = (double.Parse(Console.ReadLine()) / 100);//height arr
            }
            for (int i = 0; i < n; ++i)
            {
                PersonData[i, 2] = (PersonData[i, 0] / Math.Pow(PersonData[i, 1], 2));
                if (PersonData[i, 2] <= 18.4)
                {
                    status[i] = "Underweight";
                }
                else if ((PersonData[i, 2] >= 18.5) && (PersonData[i, 2] <= 24.9))
                {
                    status[i] = "Normal";
                }
                else if ((PersonData[i, 2] >= 25.0) && (PersonData[i, 2] <= 39.9))
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
                Console.WriteLine($"weight: {PersonData[i, 0]}, height: {PersonData[i, 1]}, BMI: {PersonData[i, 2]:f}, status: {status[i]}");
            }
        }
        
    }
}
