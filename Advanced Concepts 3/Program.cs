using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            var persons = new[]
            {
                new { PersonName = "Scott", Email = "scott@gmail.com" },
                new { PersonName = "Smith", Email = "smith@gmail.com" },
                new { PersonName = "Allen", Email = "allen@gmail.com" },
                new { PersonName = "Jones", Email = "jones@gmail.com" }
            };

            foreach (var item in persons)
            {
                Console.Write(item.PersonName);
                Console.Write(", ");
                Console.WriteLine(item.Email);
            }

            Console.ReadKey();
        }
    }
}
