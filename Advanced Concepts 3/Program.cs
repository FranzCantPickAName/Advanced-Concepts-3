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

            SortedList<int, string> employees = new SortedList<int, string>()
            {
                { 102, "Smith" },
                { 105, "James" },
                { 103, "Allen" },
                { 101, "Scott" },
                { 104, "Jones" }
            };

            employees.Add(100, "Anna");

            employees.Remove(100);

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            string s = employees[105];
            Console.WriteLine("\nValue at 105: " + s);

            Console.WriteLine("\nKeys: ");
            foreach (int item in employees.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nValues: ");
            foreach (string item in employees.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            bool a = employees.ContainsKey(105);
            Console.WriteLine("ContainsKey 105: " + a);

            bool b = employees.ContainsValue("Scott");
            Console.WriteLine("ContainsValue Scott: " + b);

            int keyIndex = employees.IndexOfKey(101);
            Console.WriteLine("\nIndex of 101: " + keyIndex);

            int valueIndex = employees.IndexOfValue("Allen");
            Console.WriteLine("\nIndex of Allen: " + valueIndex);

            ////employees.Clear();

            Console.ReadKey();
        }
    }
}
