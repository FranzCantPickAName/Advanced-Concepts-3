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
                new Employee() { EmpID = 101, EmpName = "Scott"},
                new Employee() { EmpID = 102, EmpName = "Smith" },
                new Employee() { EmpID = 103, EmpName = "John" },
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.EmpID + ", " + employee.EmpName);
            }

            Console.ReadKey();

        }
    }
}
