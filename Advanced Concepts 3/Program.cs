using ClassLibrary1;
using System;

namespace EventsSample
{
    class Program
    {
        static void Main()
        {

            Publisher publisher = new Publisher();

            publisher.myEvent += (a) =>
            {
                return a >= 0;
            };

            Console.WriteLine(publisher.RaiseEvent(10));
            Console.WriteLine(publisher.RaiseEvent(-5));
            Console.WriteLine(publisher.RaiseEvent(-14));


            Console.ReadKey();
        }
            
            
            }
}