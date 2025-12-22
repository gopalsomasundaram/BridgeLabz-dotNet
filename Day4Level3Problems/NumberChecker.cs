using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class NumberChecker
    {
        static int GetDigitCount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n /= 10;
            }
            return count;
        }

        static int[] IntToArray(int number, int count)
        {
            int[] arr = new int[number];
            for(int i = 0; i < count; i++)
            {
                arr[i] = number % 10;
                number /= 10;
            }
            return arr;
        }
        static bool IsDuckNumber(int[] arr, int count)
        {
            if (arr[count-1] == 0) return false;
            else
            {
                for(int i = 0; i < count-1; ++i)
                {
                    if (arr[i] == 0)
                    {
                        return true; 
                    }
                }
                return false;
            }

        }
        static bool IsArmstrongNumber(int number, int[] arr, int count)
        {
            int sum = 0;
            for(int i = 0; i < count; ++i)
            {
                sum += (int)Math.Pow(arr[i], count);
            }
            if(number == sum ) return true;
            else return false;
        }
        static int[] LargestAndSecondLargest(int[] arr, int count)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            for(int i = 0; i < count; ++i)
            {
                if (arr[i] >= largest)
                {
                    secondLargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] != largest && secondLargest < arr[i])
                {
                    secondLargest = arr[i];
                }
            }
            int[] result = new int[] { largest, secondLargest };
            return result;
        }
        static int[] SmallestAndSecondSmallest(int[] arr, int count)
        {
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;
            for (int i = 0; i < count; ++i)
            {
                if (arr[i]<=smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] != smallest && secondSmallest > smallest)
                {
                    secondSmallest = arr[i];
                }
            }
            int[] result = new int[] { smallest , secondSmallest};
            return result;
        }
        static int SumOfDigits(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        static int SumOfSquaresOfDigits(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += (int) Math.Pow(i,2);
            }
            return sum;
        }
        static bool IsHarshadNumber(int[] arr,int number)
        {
            int sum = SumOfDigits(arr);
            if(number%sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int[,] GetFrequency(int[] arr, int count)
        {
            int[,] frequency = new int[10, 2];
            for(int i = 0; i < count; ++i)
            {
                frequency[arr[i], 1] += 1;
            }
            return frequency;

        }
        static int[] ReverseArray(int[] arr, int count)
        {
            int[] rev_arr = new int[count];
            int reverseCounter = count - 1;
            int index = 0;
            for(int i = count - 1; i >= 0; --i)
            {
                rev_arr[index] = arr[i];
                index++;
            }
            return rev_arr;
        }
        static bool isEqualArrays(int[] arr1, int[] arr2,int count)
        {
            for(int i = 0; i < count; ++i)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPalindrome(int[] arr, int count)
        {
            return isEqualArrays(arr, ReverseArray(arr, count), count);
        }
        static bool IsPrime(int number)
        {
            for(int i = 2; i < number;++i)
            {
                if(number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsNeonNumber(int number)
        {
            int squared = (int)Math.Pow(number, 2);
            int sum = SumOfDigits(IntToArray(squared, GetDigitCount(squared)));
            if (sum == number)
            {
                return true;
            }
            else return false;
        }
        static bool IsBuzzNumber(int number)
        {
            if (number % 7 == 0 || number % 10 == 7)
            {
                return true;
            }
            else return false;
        }
        static bool IsSpyNumber(int number,int[] arr,int count)
        {
            int sum = SumOfDigits(arr);
            int prod = 1;
            for(int i =0;i<count;i++)
            {
                prod *= arr[i];
            }
            //Console.WriteLine($"{sum} and {prod}");
            if (sum == prod) return true;
            else return false;
        }
        static int[] GetFactorsArray(int number)
        {
            int factorCount = 0;
            for(int i = 1; i < number; ++i)
            {
                if(number%i == 0)
                {
                    factorCount++;
                }
            }
            int[] factors = new int[factorCount];
            factorCount = 0;
            for (int i = 1; i < number; ++i)
            {
                if (number % i == 0)
                {
                    factors[factorCount] = i;
                    factorCount++;
                }
            }
            return factors;
        }
        static bool IsAutomorphic(int number)
        {
            int num = (int)Math.Pow(number, 2);
            if (number == num % 10)
            {
                return true;
            }
            else return false;
        }
        static int ProductOfArray(int[] arr)
        {
            int product = 1;
            for(int i = 0; i < arr.Length; ++i)
            {
                product *= arr[i];
            }
            return product;
        }
        static int ProductOfCubeArray(int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; ++i)
            {
                product *= (int)Math.Pow(arr[i],3);
            }
            return product;
        }
        static bool IsPerfectNumber(int number)
        {
            int[] factors = GetFactorsArray(number);
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            if (sum == number) return true;
            else return false;
        }
        static bool IsAbundantNumber(int number)
        {
            int[] factors = GetFactorsArray(number);
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            if (sum > number) return true;
            else return false;
        }
        static bool IsDeficientNumber(int number)
        {
            int[] factors = GetFactorsArray(number);
            int sum = 0;
            for (int i =0;i<factors.Length;i++)
            {
                sum += factors[i];
            }
            if (sum < number) return true;
            else return false;
        }
        static int Factorial(int n)
        {
            if (n == 1) return 1;
            else return n * Factorial(n - 1);
        }
        static bool IsStrongNumber(int number, int[] digits,int count)
        {
            int sum = 0;
            for(int i = 0; i < count; i++)
            {
                sum += Factorial(digits[i]);
            }
            if(sum ==  number) return true;
            else return false;
        }
        public static void Main()
        {
            Console.WriteLine("Enter Positive Number:");
            int number = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Invalid Input");
            }

            int count = GetDigitCount(number);
            Console.WriteLine($"The given number has {count} digits");

            int[] digits = IntToArray(number, count);
            Console.WriteLine("Digits array:");
            for(int i = 0; i < count; ++i)
            {
                Console.WriteLine(digits[i]);
            }

            if (IsDuckNumber(digits, count))
            {
                Console.WriteLine("The given number is a duck number");
            }
            else
            {
                Console.WriteLine("The given number is not a duck number");
            }

            if(IsArmstrongNumber(number, digits, count))
            {
                Console.WriteLine("The given number is a Armstrong number");
            }
            else
            {
                Console.WriteLine("The given number is not a Armstrong number");
            }

            int[] arr1 = LargestAndSecondLargest(digits, count);
            Console.WriteLine($"The Largest digit is {arr1[0]} and the second largest is {arr1[1]}");

            int[] arr2 = SmallestAndSecondSmallest(digits, count);
            Console.WriteLine($"The Smallest digit is {arr2[0]} and the second smallest is {arr2[1]}");

            Console.WriteLine($"The sum of all the digits in number is {SumOfDigits(digits)}");
            Console.WriteLine($"The sum of all the squares of digits in number is {SumOfSquaresOfDigits(digits)}");

            if (IsHarshadNumber(digits, number))
            {
                Console.WriteLine("The given number is a harshad number");
            }
            else
            {
                Console.WriteLine("The given number is not a harshad number");
            }

            int[,] frequency = GetFrequency(digits, count);
            Console.WriteLine("Frequency of digits:");
            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"{i} => {frequency[i,1]}");
            }

            int[] reverseArray = ReverseArray(digits, count);
            Console.WriteLine("Digits array reversed:");
            foreach (int i in reverseArray)
            {
                Console.WriteLine(i);
            }

            if (isEqualArrays(digits, digits, count))
            {
                Console.WriteLine("Both the arrays passed as arguments are equal");
            }
            else Console.WriteLine("Both the arrays passed as arguments are not equal");

            if (IsPalindrome(digits, count))
            {
                Console.WriteLine("The give number is a palindrome");
            }
            else Console.WriteLine("The give number is not a palindrome");

            if (IsPrime(number))
            {
                Console.WriteLine("The given number is a prime number");
            }
            else Console.WriteLine("The given number is not a prime number");

            if (IsNeonNumber(number))
            {
                Console.WriteLine("The given number is a neon number");
            }
            else Console.WriteLine("The given number is not a neon number");

            if (IsSpyNumber(number,digits,count))
            {
                Console.WriteLine("The given number is a spy number");
            }
            else Console.WriteLine("The given number is not a spy number");

            if (IsAutomorphic(number))
            {
                Console.WriteLine("The given number is automorphic");
            }
            else Console.WriteLine("The given number is not automorphic");

            if (IsBuzzNumber(number))
            {
                Console.WriteLine("The given number is a buzz number");
            }
            else Console.WriteLine("The given number is not a buzz number");

            int[] factors = GetFactorsArray(number);
            Console.WriteLine("The factors of the given number are:");
            foreach(int i in factors)
            {
                Console.WriteLine(i);
            }
            int[] largestFactor = LargestAndSecondLargest(factors, factors.Length);
            Console.WriteLine($"The Greatest Factor of the number is {largestFactor[0]}");

            Console.WriteLine($"Product of all factors of number is {ProductOfArray(factors)}");

            Console.WriteLine($"Product of all factors of number is {ProductOfCubeArray(factors)}");

            if (IsPerfectNumber(number))
            {
                Console.WriteLine("The give number is a perfect number");
            }else Console.WriteLine("The give number is not a perfect number");

            if (IsAbundantNumber(number))
            {
                Console.WriteLine("The give number is a Abundant number");
            }
            else Console.WriteLine("The give number is not a Abundant number");

            if (IsDeficientNumber(number))
            {
                Console.WriteLine("The give number is a Deficient number");
            }
            else Console.WriteLine("The give number is not a Deficient number");

            ;
            if (IsStrongNumber(number,digits, count))
            {
                Console.WriteLine("The give number is a strong number");
            }
            else Console.WriteLine("The give number is not a strong number");
        }
    }
}
