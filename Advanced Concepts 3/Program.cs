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
            //collection of objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 104, EmpName = "Mary", Job = "Designer"},
                new Employee() { EmpID = 102, EmpName = "Alexa", Job = "Manager"},
                new Employee() { EmpID = 101, EmpName = "Steven", Job = "Consultant"},
                new Employee() { EmpID = 103, EmpName = "Jade", Job = "Manager"},
                new Employee() { EmpID = 105, EmpName = "Sara", Job = null}
            };

            CustomComparer customComparer = new CustomComparer();
            customComparer.sortBy = SortBy.Job;
            employees.Sort(customComparer); //EmpName
            //employees.Reverse();

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.EmpID + ", " + emp.EmpName + ", " + emp.Job);
            }

            Console.ReadKey();
        }
    }
}
