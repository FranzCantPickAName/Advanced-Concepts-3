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
            HashSet<string> employees2021 = new HashSet<string>()
            {
                "Amir", "Soheil", "Saman"
            };
            HashSet<string> newEmployees2022 = new HashSet<string>()
            {
                "John", "Scott", "Smith", "Steve"
            };

            employees2021.UnionWith(newEmployees2022);

            foreach (string item in employees2021)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            HashSet<string> employees2021_I = new HashSet<string>()
            {
                "Amir", "Soheil", "Saman"
            };
            HashSet<string> newEmployees2022_I = new HashSet<string>()
            {
                "John", "Amir", "Soheil", "Scott", "Smith", "Steve"
            };

            employees2021_I.IntersectWith(newEmployees2022_I);
            foreach (string item in employees2021_I)
                { Console.WriteLine(item); }

            Console.ReadKey();
        }
    }
}
