using System.Security.Cryptography;

namespace ConsoleAppTest.Day1Level1Problems
{
    class Q1 { 
        public static void func () {
            Console.WriteLine("Welcome to Bridgelabz");
        }
    }
    class Q2
    {
        public static void func() {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of both integers are: " + (x + y));
        }
    }

    class Q3
    {
        public static void func() {
            double celsius = Convert.ToDouble(Console.Read());
            Console.WriteLine("Farenheit: "+((celsius*(9/5))+32));
        }
    }

    class Q4
    {
        public const double PI = 3.14159265359;
        public static void func() {
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the area of the circle is: {0:F2}",(PI*Math.Pow(radius,2)));
        }
    }

    class Q5 {
        public static void func()
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the volume is: {0:F2}", (Q4.PI * Math.Pow(radius, 2) * height));
        }
    }
    class Q6 {
        public static void func() {
            int principal = Convert.ToInt32(Console.ReadLine());
            int rate = Convert.ToInt32(Console.ReadLine());
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("simple interest is: {0}",((principal*rate*time)/100));
        }
    }
    class Q7 {
        public static void func() {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("perimeter of rectangle = {0}", (2 * (length + width)));
        }
    }
    class Q8 {
        public static void func() { 
            int base_num = Convert.ToInt32(Console.ReadLine());
            int exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("result is: {0}",Math.Pow(base_num,exp));
        }
    }
    class Q9 {
        public static void func() {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("average of these 3 numbers is: {0}",((num1+num2+num3)/3));
        }
    }
    class Q10 { 
        public static void func() {
            double km = Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("miles: {0:F3}",(km* 0.621371));
        }
    }
    class Program {
        public static void Main(string[] args) {
            Q10.func();
        }
    }
}