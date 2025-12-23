using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class SubstringOccurrences
    {
        static int NumOccurrences(string text, string substring)
        {
            int count = 0;
            for(int i = 0; i < text.Length-substring.Length; ++i)
            {
                if (text.Substring(i, substring.Length) == substring)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string to be checked:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the string to be searched:");
            string sub = Console.ReadLine();
            int result = NumOccurrences(str, sub);
            Console.WriteLine($"There are {result} occurence(s) of the given search term in the string");
        }
    }
}
