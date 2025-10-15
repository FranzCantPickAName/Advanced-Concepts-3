using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter first number: ");
                string input1 = Console.ReadLine();
                a = int.Parse(input1);
                Console.WriteLine("Enter second number: ");
                string input2 = Console.ReadLine();
                b = int.Parse(input2);

                int c = a / b;
                Console.WriteLine("Result of division is: " + c);
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
