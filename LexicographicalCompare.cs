using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class LexicographicalCompare
    {
        static int Lexicographi(string str1, string str2)
        {
            int min = Math.Min(str1.Length, str2.Length);
            for(int i = 0; i < min; ++i)
            {
                if (str1[i] != str2[i])
                {
                    return str1[i] - str2[i];
                }
            }
            return str1.Length - str2.Length;
        }
        public static void Main()
        {
            Console.WriteLine("enter the first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter the second string:");
            string str2 = Console.ReadLine();
            int result = Lexicographi(str1, str2);
            if(result < 0)
            {
                Console.WriteLine("first string is smaller");
            }
            else if (result == 0)
            {
                Console.WriteLine("both strings are equal");
            }
            else
            {
                Console.WriteLine("second string is smaller");
            }
        }
    }
}
