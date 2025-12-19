using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class BMI
    {
        double[,] calcBMI(double[,] arr)
        {
            for(int i = 0; i < 10; ++i)
            {
                arr[i, 2] = (arr[i, 0] / Math.Pow((arr[i, 1] / 100),2));
            }
            return arr;
        }
        string[] GetStatus(double[,] arr)
        {
            string[] statuses = new string[10];
            for(int i = 0; i < 10; ++i)
            {
                if (arr[i, 2] <= 18.4)
                {
                    statuses[i] = "Underweight";
                }
                else if (arr[i,2]>=18.5 && arr[i, 2] <= 24.9)
                {
                    statuses[i] = "Normal";
                }
                else if(arr[i,2]>=25.0 && arr[i, 2] <= 39.9)
                {
                    statuses[i] = "Overweight";
                }
                else
                {
                    statuses[i] = "Obese";
                }
                
            }
            return statuses;
        }
        public static void Main()
        {
            double[,] arr = new double[10,3];
            Console.WriteLine("Enter the weight of 10 people:");
            for(int i = 0; i < 10; i++)
            {
                arr[i, 0] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the height of 10 people:");
            for (int i = 0; i < 10; i++)
            {
                arr[i, 1] = double.Parse(Console.ReadLine());
            }
            var obj = new BMI();
            arr = obj.calcBMI(arr);
            string[] status = obj.GetStatus(arr);
            foreach(string i in status)
            {
                Console.WriteLine(i);
            }
        }
    }
}
