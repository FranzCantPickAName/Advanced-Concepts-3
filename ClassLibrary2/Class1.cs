using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{

    //moodel class
    public class LivingThing
    {
        public int NumberOfLegs { get; set; }

    }

    public class Parrot: LivingThing
    {

    }

    public class Dog: LivingThing
    {

    }

    public interface IMover<out T>
    {
        T Move();
    }

    public class Mover<T> : IMover<T>
    {
        public T thing { get; set; }
        public T Move()
        {
            return thing;
        }
    }

    public class Sample
    {
        public void PrintValues(IEnumerable<object> values)
        {
            foreach (var item in values)
            {
                Console.WriteLine(item + ", ");
            }
            Console.WriteLine();
        }
    }

}

