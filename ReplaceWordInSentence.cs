using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class ReplaceWordInSentence
    {
        static string ReplaceWord(string strFull, string str1, string str2)
        {
            string[] strArr = strFull.Split(" ");
            for(int i = 0; i < strArr.Length; ++i)
            {
                if (strArr[i] == str1)
                {
                    strArr[i] = str2;
                }
            }
            return string.Join(" ", strArr);
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the word to be replaced");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the word to be replaced by");
            string b = Console.ReadLine();
            Console.WriteLine("Processed string");
            Console.WriteLine(ReplaceWord(str,a,b));
        }
    }
}
