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
            Stack<Student> marks = new Stack<Student>();

            marks.Push(new Student() { Marks = 45 });
            marks.Push(new Student() { Marks = 61 });
            marks.Push(new Student() { Marks = 80 });

            Student stuPop = marks.Pop();
            Console.WriteLine("Pop: " + stuPop.Marks);

            Student stuPeek = marks.Peek();
            Console.WriteLine("Peek: " + stuPeek.Marks);

            int r = 1;
            foreach (Student item in marks)
            {
                item.Rank = r;
                Console.WriteLine(item.Marks + ", " + item.Rank);
                r++;
            }

            Console.ReadKey();
        }
    }
}
