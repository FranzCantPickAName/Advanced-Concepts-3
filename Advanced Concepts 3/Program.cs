using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string director = "Sam Raimi", movie = "Spiderman";
            string message = string.Format("{0} is the director of {1}", director, movie);
            string message2 = $"{director} is the director of {movie}";

            Console.WriteLine(message);
            Console.WriteLine(message2);


            Console.ReadKey();
        }
    }
}
