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
            //list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 104, EmpName = "Mary", Job = "Designer" },
                new Employee() { EmpID = 102, EmpName = "Alexa", Job = "Manager" },
                new Employee() { EmpID = 101, EmpName = "Steven", Job = "Consultant" },
                new Employee() { EmpID = 103, EmpName = "Jade", Job = "Analyst" }
            };
            employees.Sort();
            foreach (Employee item in employees)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job);
            }

            Console.ReadKey();
        }
    }
}
