using ClassLibrary1;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Regex regex = new Regex("^[A-Za-z ]*$");

            Console.WriteLine("Enter a name: ");
            string inputValue = Console.ReadLine();
            bool result = regex.IsMatch(inputValue);
            Console.WriteLine(result);
            if (result)
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Inalid name");
            }

            Console.ReadKey();
        }
    }
}
