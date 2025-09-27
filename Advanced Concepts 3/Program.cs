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
            Person p = new Person();

            var person = new { PersonName = p.GetPersonName(), Age = p.GetPersonAge(), Address = new { Street = "abc", City = "xyz" } };

            Console.WriteLine(person.PersonName);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Address.City);
            Console.WriteLine(person.Address.Street);

            Console.ReadKey();
        }
    }
}
