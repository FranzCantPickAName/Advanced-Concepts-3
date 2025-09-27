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
            LivingThing livingThing = new Parrot();
            Parrot parrot = new Parrot() { NumberOfLegs = 2 };

            IMover<LivingThing> mover = new Mover<Parrot>() { thing = parrot };
            Console.WriteLine("Moving with " + mover.Move().NumberOfLegs + " legs");

            Sample sample = new Sample();
            sample.PrintValues(new List<string>() { "hello", "world" });

            Console.ReadKey();
        }
    }
}
