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
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Task 3");
            queue.Enqueue("Task 5");
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 4");
            queue.Enqueue("Task 2");

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            string dequeue1 = queue.Dequeue();
            Console.WriteLine("Dequeue: " + dequeue1);
            string dequeue2 = queue.Dequeue();
            Console.WriteLine("Dequeue: " + dequeue2);

            string peek = queue.Peek();
            Console.WriteLine("Peek: " + peek);

            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
