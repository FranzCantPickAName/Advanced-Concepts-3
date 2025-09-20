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

            Hashtable employees = new Hashtable()
            {
                { 102, "Smith" },
                { 105, "James" },
                { 103, "Allen" },
                { 101, "Scott" },
                { 104, "Jones" },
                { "hello", 10.934 }
            };

            employees.Add(100, "Anna");

            employees.Remove(103);

            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + ", " + item.Value);
            }

            if (employees[105] is string)
            {
                string value = Convert.ToString(employees[105]);
                Console.WriteLine(value);
            }
            else if (employees[105] is double)
            {
                double value = Convert.ToDouble(employees[105]);
                Console.WriteLine(value);
            }

                Console.WriteLine("\nKeys: ");
                foreach (var item in employees.Keys)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nValues: ");
                foreach (var item in employees.Values)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();

                bool a = employees.ContainsKey(105);
                Console.WriteLine("ContainsKey 105: " + a);

                bool b = employees.ContainsValue("Scott");
                Console.WriteLine("ContainsValue Scott: " + b);

                //int keyIndex = employees.IndexOfKey(101);
                //Console.WriteLine("\nIndex of 101: " + keyIndex);

                //int valueIndex = employees.IndexOfValue("Allen");
                //Console.WriteLine("\nIndex of Allen: " + valueIndex);

                ////employees.Clear();

                Console.ReadKey();
        }
    }
}
