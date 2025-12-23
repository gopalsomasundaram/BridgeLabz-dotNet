using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class SplitString
    {
        static int GetLength(string str)
        {
            int count = 0;
            Console.WriteLine($"Getting Length of {str}");
            while (true)
            {
                try
                {
                    Console.WriteLine(str[count++]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    return count - 1;
                }
            }
        }

        static int GetNumberOfWords(string text)
        {
            text = text.Trim();
            string.Concat(text, " ");
            Console.WriteLine($"Given input is {text}");
            int spaceCount = 0;
            int len = GetLength(text);

            for (int i = 0; i < len; ++i)
            {
                if (text[i] == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount + 1;
        }

        static string[] SplitToWords(string text)
        {
            int len = GetLength(text);
            int numWords = GetNumberOfWords(text);
            Console.WriteLine($"input length {len} and number of words: {numWords}");
            string[] words = new string[numWords+1];
            int index = 0;
            for(int i = 0; i < len - 1; ++i)
            {
                for(int j = i + 1; j < len; ++j)
                {
                    if (i == ' ') continue;
                    if (text[j] == ' ')
                    {
                        //Console.WriteLine($"Adding {text.Substring(i, j - i)} to string array");
                        words[index++] = text.Substring(i, j - i);
                        i = j+1;
                    }
                    if(i!= 0)
                    {
                        if (text[i-1] == ' ' && j == len - 1)
                        {
                            words[index] = text.Substring(i, j-i+1); break;
                        }
                    }
                    //Console.WriteLine($"outer i :{i}; inner j : {j}");
                }
            }
            return words;
        }
        public static void Main()
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            string[] arr = SplitToWords(str);
            Console.WriteLine("Words of the given string are: ");
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine($"{arr[i]} ");
            }
            int numberOfWords = GetNumberOfWords(str);
            string[,] result = new string[numberOfWords,2];
            Console.WriteLine("Result:");
            for(int i = 0; i < numberOfWords; ++i)
            {
                result[i, 0] = arr[i];
                result[i, 1] = Convert.ToString(GetLength(arr[i]));
                Console.WriteLine($"{result[i, 0]} {result[i, 1]}");
            }
        }
    }
}
