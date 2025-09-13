using ClassLibrary1;
using System;

namespace EventsSample
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.DoWork();
            Console.ReadKey();
        }

        public void DoWork()
        {

            Publisher publisher = new Publisher();

            publisher.myEvent += (sender, e) =>
            {
                int c = e.a + e.b;
                Console.WriteLine(c);
            };

            publisher.RaiseEvent(this, 10, 50);
            publisher.RaiseEvent(this, -5, 30);
            publisher.RaiseEvent(this, 14, 10);


            
        }
            
            
            }
}