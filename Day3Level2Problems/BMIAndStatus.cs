using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class BMIAndStatus
    {
        public static void calc()
        {
            int num = int.Parse(Console.ReadLine());
            double[] weight = new double[num];
            double[] height = new double[num];
            double[] BMI = new double[num];
            string[] status = new string[num];
            Console.WriteLine("Enter weight:");
            for(int i = 0; i < num; ++i)
            {
                weight[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter height:");
            for (int i = 0; i < num; ++i)
            {
                height[i] = (double.Parse(Console.ReadLine())/100);
            }
            for(int i = 0; i < num; ++i)
            {
                BMI[i] = (weight[i] / Math.Pow(height[i], 2));
                if (BMI[i] <= 18.4)
                {
                    status[i] = "Underweight";
                }else if ((BMI[i] >= 18.5) && (BMI[i] <= 24.9))
                {
                    status[i] = "Normal";
                }
                else if((BMI[i] >= 25.0) && (BMI[i] <= 39.9))
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
                Console.WriteLine($"weight: {weight[i]}, height: {height[i]}, BMI: {BMI[i]:f}, status: {status[i]}");
            }
        }
    }
}
