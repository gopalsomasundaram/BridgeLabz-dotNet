using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class UnitConverter
    {
        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km2miles * km;
        }
        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles2km * miles;
        }
        public static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters2feet * meters;
        }
        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet2meters * feet;
        }
        public static double ConvertYardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards2feet * yards;
        }
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet2yards * feet;
        }
        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters2inches * meters;
        }
        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches2meters * inches;
        }
        public static double ConvertInchesToCentimeters(double cm)
        {
            double inches2cm = 2.54;
            return inches2cm * cm;
        }
        public static double FarhenheitToCelsius(double farhenheit)
        {
            double farhenheit2celsius = (farhenheit - 32) * 5 / 9;
            return farhenheit2celsius;
        }
        public static double CelsiusToFarhenheit(double celsius)
        {
            double celsius2farhenheit = (celsius * 9 / 5) + 32;
            return celsius2farhenheit;
        }
        public static double PoundsToKilograms(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds2kilograms*pounds;
        }
        public static double KilogramsToPounds(double kg)
        {
            double kilograms2pounds = 2.20462;
            return kilograms2pounds * kg;
        }
        public static double GallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons2liters * gallons;
        }
        public static double LitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters2gallons * liters;
        }
        public static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(CelsiusToFarhenheit(x));
        }
    }
}
