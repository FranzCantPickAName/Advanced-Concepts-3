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

            myDelegate = new MyDelegateType(s.Add);

            Console.WriteLine(myDelegate.Invoke(30, 40));

            Console.ReadKey();
        }
    }
}
