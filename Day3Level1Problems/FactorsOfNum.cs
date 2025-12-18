using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class FactorsOfNum
    {
        public static void calc()
        {
            int number = int.Parse(Console.ReadLine());
            int maxFactors = 10, index = 0;
            int[] factors = new int[maxFactors];
            for (int i = 1; i <= number; ++i)
            {
                if ((number % i) == 0)
                {
                    if (index == (maxFactors - 1))
                    {
                        int[] temp = factors;
                        maxFactors *= 2;
                        int[] biggerFactors = new int[maxFactors];
                        for(int j = 0; j < temp.Length; ++j)
                        {
                            biggerFactors[j] = temp[j];
                        }
                        factors = biggerFactors;
                    }
                    factors[index++] = i;
                }
            }
            foreach (int num in factors)
            {
                Console.WriteLine(num);
            }
        }
    }
}
