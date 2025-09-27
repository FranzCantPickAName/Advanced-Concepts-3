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
            //create normal object
            Parrot parrot = new Parrot() { NumberOfLegs = 2 };
            Dog dog = new Dog() { NumberOfLegs = 4 };

            // Contravariance = supply the parent type name, where the child type name is expected.
            IMover<Parrot> obj1 = new Mover<Parrot>(); //normal
            IMover<Parrot> obj2 = new Mover<LivingThing>();
            //"Parrot" vs "LivingThing"; supplying the parent type (LivingThing), where the child type (Parrot) is expected.
            obj2.Move(parrot);

            IMover<Dog> obj3 = new Mover<LivingThing>();
            obj3.Move(dog);

            Console.ReadKey();
        }
    }
}
