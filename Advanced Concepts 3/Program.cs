using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Sample s = new Sample();

            MyDelegateType myDelegate;

            myDelegate = s.Add;

            myDelegate += s.Multiply;

            myDelegate.Invoke(40, 10);

            Console.ReadKey();
        }
    }
}