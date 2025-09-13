using ClassLibrary1;
using System;

namespace EventsSample
{
    class Program
    {
        static void Main()
        {

            Publisher publisher = new Publisher();

            //publisher.myEvent += (a, b) =>
            //{
            //    int c = a + b;
            //    return c;
            //};
            publisher.myEvent += (a, b) => a + b;

            Console.WriteLine(publisher.RaiseEvent(10, 20));
            Console.WriteLine(publisher.RaiseEvent(5, 80));
            Console.WriteLine(publisher.RaiseEvent(14, 22));


            Console.ReadKey();
        }
            
            
            }
}