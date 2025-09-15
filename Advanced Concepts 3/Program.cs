using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            List<int> intCollection = new List<int>() { 1, 8, 2, 7 };

            List<string> strCollection = intCollection.ConvertAll<string>((n) =>

            {
                string word;
                switch (n)
                {
                    case 1: word = "One"; break;
                    case 2: word = "Two"; break;
                    case 3: word = "Three"; break;
                    case 4: word = "Four"; break;
                    case 5: word = "Five"; break;
                    case 6: word = "Six"; break;
                    case 7: word = "Seven"; break;
                    case 8: word = "Eight"; break;
                    case 9: word = "Nine"; break;
                    default: word = ""; break;
                }
                return word;

            }
            );

            foreach (string str in strCollection)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
