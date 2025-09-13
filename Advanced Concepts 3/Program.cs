using ClassLibrary1;
using System;

namespace EventsSample
{
    class Program
    {
        static void Main()
        {

            Publisher publisher = new Publisher();

            publisher.myEvent += (a, b) =>
            {
                int c = a + b;
                Console.WriteLine(c);
            };

            publisher.RaiseEvent(10, 20);
            publisher.RaiseEvent(5, 80);
            publisher.RaiseEvent(14, 22);


            Console.ReadKey();
        }
            
            
            }
}