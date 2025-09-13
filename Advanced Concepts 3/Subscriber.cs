using System;
using ClassLibrary1;

namespace EventsSample
{
    public class Subscriber
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
