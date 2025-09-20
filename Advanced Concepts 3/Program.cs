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
            HashSet<string> messages = new HashSet<string>()
            {
                "Good Morning", "How Are You", "Have a good day"
            };

            messages.Add("Good Luck");
            messages.Remove("Have a good day");
            messages.RemoveWhere(m => m.EndsWith("You"));

            bool b = messages.Contains("Good Morning");
            Console.WriteLine("Contains 'Good Morning' : " + b);

            Console.WriteLine("\nCount: " + messages.Count);

            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }

                Console.ReadKey();
        }
    }
}
