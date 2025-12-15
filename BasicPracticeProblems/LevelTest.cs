using System;

namespace ConsoleAppTest.BasicPracticeProblems {
    class HarryAge { 
        public static void calcAge() {
            int currentYear = 2024;
            Console.WriteLine("Harry's age in 2024 is {0}", (currentYear-2000));
        }
    }
    class SamMarks {
        public static void calcAverage() {
            int physicsMarks = 95;
            int mathMarks = 94;
            int chemMarks = 96;
            Console.WriteLine("Sam's average mark is PCM is {0}", ((physicsMarks + mathMarks + chemMarks) / 3));
        }
    }
    class ConvertToMiles
    {
        public static void toMiles() {
            float km = 10.0f;
            Console.WriteLine($"The distance {km:f} km in miles is {km*1.6:f}");
        }
    }

    class ProfitAndLoss { 
        public static void calculate()
        {
            int costPrice = 129;
            int sellPrice = 191;
            double profit = sellPrice - costPrice;
            Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellPrice}\nThe Profit is INR {profit} and the Profit Percentage is {(profit/costPrice)*100:f}%");
        }
    }
    class DividePens
    {
        public static void calculate() {
            int numStudents = 3;
            int numPens = 14;
            Console.WriteLine($"The Pen Per Student is {numPens/numStudents} and the remaining pens not distributed is {numPens%numStudents}");
        }
    }
    class UniversityFee {
        public static void discountedFee() {
            float fullFee = 125000f;
            double discountPercentage = 10;
            double discount = fullFee * (discountPercentage/100);
            Console.WriteLine($"The discount amount is INR {discount:f} and final discounted fee is INR {fullFee - discount:f}");
        }
    }
    class EarthVolume
    {
        public static void calcVolume()
        {
            float radiusKm = 6378f;
            double volumeKm = ((4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3));
            double kmToMileFactor = 1.60934;
            double radiusMiles = radiusKm / kmToMileFactor;
            double volumeMiles = ((4.0 / 3.0) * Math.PI * Math.Pow(radiusMiles, 3));
            Console.WriteLine($"the volume of Earth in cubic kiometers is {volumeKm} and cubic miles is {volumeMiles}");
        }
    }
    class calcKmtoMi {
        public static void calcMi() {
            Console.Write("Enter the value in Kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The total miles is {km*1.6:f} mile for the given {km:f} km");
        }
    }
    class DiscountCalc
    {
        public static void discounted()
        {
            double fullFee = Convert.ToDouble(Console.ReadLine());
            double discountPercentage = Convert.ToDouble(Console.ReadLine());
            double discount = fullFee * (discountPercentage/100);
            Console.WriteLine($"The discount amount is INR {discount:f} and final discounted fee is INR {fullFee - discount:f}");
        }
    }
    class HeightConversion { 
        public static void convFeetAndInches()
        {
            double cm = Convert.ToDouble(Console.ReadLine());
            double inches = cm / 2.54;
            double feet = inches / 12;
            Console.WriteLine($"Your Height in cm is {cm:f} while in feet is {feet:f} and inches is {inches:f}");
        }
    }
    class CalcAll
    {
        public static void calc()
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {num1} and {num2} is {num1+num2}, {num1-num2}, {num1*num2} and {(num1/num2):f}");
        }
    }
    class AreaTriangle
    {
        public static void calcArea()
        {
            double triBaseCentimeter = Convert.ToDouble(Console.ReadLine());
            double triHeightCentimenter = Convert.ToDouble(Console.ReadLine());
            double triHeightInches = triHeightCentimenter / 2.54;
            double triBaseInches = triBaseCentimeter / 2.54;
            double areaCentimeters = ((triBaseCentimeter * triHeightCentimenter) / 2);
            double areaInches = ((triBaseInches* triHeightInches) / 2);
            Console.WriteLine($"Height of triangle in square cm is {areaCentimeters} and height of triangle in square inches is {Math.Round(areaInches,2)}");
        }
    }
    class Square
    {
        public static void calcPerimeter()
        {
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The length of the side is {side} whose perimeter is {4*side}");
        }
    }
    class ConvertToYardAndFeet
    {
        public static void convert()
        {
            int feet = Convert.ToInt32(Console.ReadLine());
            double yard = feet / 3;
            double miles = yard / 1760;
            Console.WriteLine($"Your distance in feet is {feet} while in yard is {yard:F} and miles is {miles:F}");
        }
    }
    class TotalPrice
    {
        public static void calcPrice()
        {
            int units = Convert.ToInt32(Console.ReadLine());
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The total purchase price is INR {units*unitPrice:f} if the quantity {units} and unit price is INR {unitPrice:f}");
        }
    }
    class CalcHandShakes
    {
        public static void calculate()
        {
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Max No. of possible handshakes among {numberOfStudents} students is {((numberOfStudents*(numberOfStudents-1))/2):f}");  
        }
    }
    class LevelTest {
        public static void Main(string[] args) {
            CalcHandShakes.calculate();
        }
    }
}
