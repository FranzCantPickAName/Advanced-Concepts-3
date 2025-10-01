using ClassLibrary1;
using System;
using System.Text;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("10 pow 4: " + Math.Pow(10, 4));
            Console.WriteLine("Min of 5.623 & 10.82: " + Math.Min(5.623, 10.82));
            Console.WriteLine("Max of 5.623 & 10.82: " + Math.Max(5.623, 10.82));
            Console.WriteLine("Floor of 20.83984: " + Math.Floor(20.83984));
            Console.WriteLine("Ceil of 20.23984: " + Math.Ceiling(20.23984));
            Console.WriteLine("Round of 20.53984: " + Math.Round(20.53984));
            Console.WriteLine("Round of 20.23984: " + Math.Round(20.23984));
            Console.WriteLine("Round of 20.53984 with 2 decimals : " + Math.Round(20.53984, 2));
            Console.WriteLine("Sign of -10: " + Math.Sign(-10));
            Console.WriteLine("Absolute value of -10: " + Math.Abs(-10));

            int rem;
            Console.WriteLine("10 divided by 3: " + Math.DivRem(10, 3, out rem) + " with remainder of " + rem);
            Console.WriteLine("Square root of 25: " + Math.Sqrt(25));

            Console.WriteLine("Logarithm of 100 with base of 10: " + Math.Log(100, 10));
            Console.WriteLine("Logarithm of 100 with base of 10: " + Math.Log10(100));
            Console.WriteLine("Logarithm of 100 with base of e: " + Math.Log(100, Math.E));

            //CSharp doesn't use these with degrees
            //Console.WriteLine("Sin of 90 degrees: " + Math.Sin(90));
            //Console.WriteLine("Cos of 90 degrees: " + Math.Cos(90));
            //Console.WriteLine("Tan of 90 degrees: " + Math.Tan(90));
            //Console.WriteLine("Co tan of 90 degrees: " + 1 / Math.Tan(90));

            Console.WriteLine("Sin of 90 degrees: " + Math.Sin(Math.PI / 2));
            Console.WriteLine("Cos of 90 degrees: " + Math.Round(Math.Cos(Math.PI / 2), 2));
            Console.WriteLine("Tan of 90 degrees: " + Math.Round(Math.Tan(Math.PI / 2)));
            Console.WriteLine("Co tan of 90 degrees: " + Math.Round(1 / Math.Tan(Math.PI / 2)));

            double newDegree = 27 * Math.PI / 180;

            Console.WriteLine("Sin of 27 degrees: " + Math.Round(Math.Sin(newDegree), 2));
            Console.WriteLine("Cos of 27 degrees: " + Math.Round(Math.Cos(newDegree), 2));
            Console.WriteLine("Tan of 27 degrees: " + Math.Round(Math.Tan(newDegree), 2));
            Console.WriteLine("Co tan of 27 degrees: " + Math.Round(1 / Math.Tan(newDegree), 2));

            Console.ReadKey();
        }
    }
}
