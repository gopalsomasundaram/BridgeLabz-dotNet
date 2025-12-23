using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class FrequentCharacter
    {
        static char FrequentChar(string arr)
        {
            char MaxOccur = char.MinValue;
            int FreqMax = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                string copy = arr;
                copy =copy.Replace(Convert.ToString(arr[i]), "");
                if(FreqMax < (arr.Length - copy.Length))
                {
                    FreqMax = arr.Length - copy.Length;
                    MaxOccur = arr[i];
                }
            }
            return MaxOccur;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            char s = FrequentChar(str);
            Console.WriteLine($"The character with the most occurrences is {s}");
        }
    }
}
