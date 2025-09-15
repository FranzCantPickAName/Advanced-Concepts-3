using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            Employee[] employees = new Employee[]
            {
                new Employee() { Role = "Developer", EmpName = "Scott"},
                new Employee() { Role = "Designer", EmpName = "Smith" },
                new Employee() { Role = "Analyst", EmpName = "John" },
            };

            Employee[] highlyPaidEmployees = new Employee[5];

            employees.CopyTo(highlyPaidEmployees, 2);
            //employees[0].Role = "Changed";

            Console.WriteLine("CopyTo: ");
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee.EmpID + ", " + employee.EmpName);
            //}
            foreach (Employee employee in highlyPaidEmployees)
            {
                if (!(employee is null))
                {
                    Console.WriteLine(employee.EmpName + ", " + employee.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }
            }

            //highlyPaidEmployees[2].Role = "Changed";
            employees[0].Role = "Changed";

            Employee[] highlyPaidEmployees2 = (Employee[])employees.Clone();
            Console.WriteLine("\nClone: ");
            foreach (Employee employee in highlyPaidEmployees2)
            {
                if (!(employee is null))
                {
                    Console.WriteLine(employee.EmpName + ", " + employee.Role);
                }
                else
                {
                    Console.WriteLine("null object");
                }


            }

            Console.ReadKey();
        }
    }

}
