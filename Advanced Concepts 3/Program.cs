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
            IEnumerable<string> messages;
            messages = new List<string>() { "How are you", "Have a great day", "Thanks for the meeting" };

            Console.WriteLine("IEnumerable:");
            foreach (string item in messages) Console.WriteLine(item);

            Console.WriteLine("\nIEnumerator:");
            IEnumerator<string> enumerator = messages.GetEnumerator();
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            Console.ReadKey();
        }
    }
}
