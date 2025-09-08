using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            MarksCalculation.CalculationHelper ch = new MarksCalculation.CalculationHelper();

            Console.WriteLine(ch.Multiply(10, 5));

            MarksCalculation mc = new MarksCalculation();
            Student s = new Student() { SecuredMarks = 35, MaxMarks = 50 };

            mc.CalculatePercentage(s);
            Console.WriteLine(s.Percentage);

            Console.ReadKey();
        }
    }
}
