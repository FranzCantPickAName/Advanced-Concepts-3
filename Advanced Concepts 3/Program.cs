using ClassLibrary1;
using System;

namespace EventsSample
{
    class Program
    {
        static void Main()
        {
            Subscriber subscriber = new Subscriber();

            Publisher publisher = new Publisher();

            publisher.myEvent += subscriber.Add;
            publisher.myEvent += subscriber.Multiply;

            publisher.RaiseEvent(10, 20);
            publisher.RaiseEvent(5, 80);
            publisher.RaiseEvent(14, 22);


            Console.ReadKey();
        }
            
            
            }
}