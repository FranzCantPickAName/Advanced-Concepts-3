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
            ArrayList arrayList = new ArrayList() { 100, 'A' } ;

            Sample sample = new Sample() ;

            arrayList.Add(sample.GetNumber());
            arrayList.Add(sample.GetAnotherNumber());
            arrayList.Add(sample.GetMessage());
            arrayList.Add(sample.GetEmployee());

            foreach (var item in arrayList)
            {
                if (item is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeName);
                }
                else
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
