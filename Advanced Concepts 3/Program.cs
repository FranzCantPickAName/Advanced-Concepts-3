using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Binary: ");

            int dec1 = 13;

            //Display the decimal as a string in base 2
            //Second argument is the base we WANT
            string binary1 = Convert.ToString(dec1, 2);
            Console.WriteLine(binary1);

            //Convert that binary string back to decimal
            //Second argument is the base that we are INPUTTING
            int dec2 = Convert.ToInt32(binary1, 2);
            Console.WriteLine(dec2);

            int n = 0b1100100;
            n += 1;
            Console.WriteLine(n);

            Console.WriteLine("\nOctal: ");

            int dec3 = 289;
            string oct1 = Convert.ToString(dec3, 8);
            Console.WriteLine(oct1);

            int dec4 = Convert.ToInt32(oct1, 8);
            Console.WriteLine(dec4);

            //int n2 = 0144;
            //Console.WriteLine(n2);

            Console.WriteLine("\nHexadecimal: ");

            int dec5 = 742;
            string hex1 = Convert.ToString(dec5, 16);
            Console.WriteLine(hex1);

            int dec6 = Convert.ToInt32(hex1, 16);
            Console.WriteLine(dec6);

            int n3 = 0x64;
            n3 += 1;
            Console.WriteLine(n3);

            Console.ReadKey();
        }
    }
}
