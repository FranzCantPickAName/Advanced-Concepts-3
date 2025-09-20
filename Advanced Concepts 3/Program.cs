using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                { 101, "Scott" },
                { 102, "Smith" },
                { 103, "Allen" }
            };

            employees.Add(104, "Mark");
            //Keys in a dictionary must be unique
            //employees.Add(104, "Steve");

            employees.Remove(102);

            string s = employees[101];
            Console.WriteLine("\nValue at 101: " + s);

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            Dictionary<int, string>.KeyCollection keys = employees.Keys;

            Console.WriteLine("\nKeys: ");
            foreach (int item in keys)
            {
                Console.WriteLine(item);
            }

            bool a = employees.ContainsKey(103);
            Console.WriteLine("ContainsKey: " + a);

            bool b = employees.ContainsValue("Scott");
            Console.WriteLine("ContainsValue: " + b);

            //employees.Clear();

            Console.ReadKey();
        }
    }
}
