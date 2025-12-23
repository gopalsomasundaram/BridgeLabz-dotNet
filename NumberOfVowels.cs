using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleAppTest
{
    internal class NumberOfVowels
    {
        static int NumberOfSpaces(string str)
        {
            int spaceCount = 0;
            for(int i = 0; i < str.Length; ++i)
            {
                if (str[i] == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;
        }
        static int VowelCount(string str)
        {
            int count = 0;
            string vowels = "aeiou";
            for(int i = 0; i < str.Length; ++i)
            {
                if (vowels.Contains(str[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the String:");
            string inp = Console.ReadLine();
            int vowelCount = VowelCount(inp);
            Console.WriteLine($"given string has {vowelCount} vowels and {inp.Length-vowelCount-NumberOfSpaces(inp)} consonants");
        }
    }
}
