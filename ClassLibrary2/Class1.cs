using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{

    public class LivingThing
    {
        public int NumberOfLegs { get; set; }
    }
    public class Parrot : LivingThing
    {
    }
    public class Dog : LivingThing
    {
    }
    public interface IMover<in T>
    {
        void Move(T x);
    }
    public class Mover<T> : IMover<T>
    {
        public void Move(T x)
        {
            if (x is Parrot)
                Console.WriteLine("Moving with " + (x as Parrot).NumberOfLegs + " legs");
            else
                Console.WriteLine("Moving with " + (x as Dog).NumberOfLegs + " legs");
        }
    }

}

