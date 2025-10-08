using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", City = "Boston" },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", City = "New York" },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", City = "Tokyo" },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", City = "Tokyo" },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", City = "New York" }
            };


            //OrderBy
            IEnumerable<Employee> resultNY = employees.Where(emp => emp.City == "New York");
            foreach (Employee item in resultNY)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.City);
            }

            Console.WriteLine();

            IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(emp => emp.EmpName);
            IOrderedEnumerable<Employee> sortedEmployees2 = employees.OrderBy(emp => emp.EmpID);
            IOrderedEnumerable<Employee> sortedEmployees3 = employees.OrderByDescending(emp => emp.EmpID);
            IOrderedEnumerable<Employee> sortedEmployees4 = employees.OrderBy(emp => emp.Job).ThenBy(emp => emp.EmpName);
            IOrderedEnumerable<Employee> sortedEmployees5 = employees.OrderByDescending(emp => emp.Job).ThenByDescending(emp => emp.EmpName);

            foreach (Employee item in sortedEmployees)
            {
                Console.WriteLine(item.EmpID + ", " + item.EmpName + ", " + item.Job + ", " + item.City);
            }

            //Using Where
            List<Employee> result = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine(result[0].EmpID + ", " + result[0].EmpName + ", " + result[0].Job + ", " + result[0].City);

            //Using First and FirstOrDefault
            Employee firstManager = employees.First(emp => emp.Job == "Manager");
            Console.WriteLine(firstManager.EmpID + ", " + firstManager.EmpName + ", " + firstManager.Job + ", " + firstManager.City);

            Employee firstClerk = employees.FirstOrDefault(emp => emp.Job == "Clerk");
            if (firstClerk != null)
            {
                Console.WriteLine(firstClerk.EmpID + ", " + firstClerk.EmpName + ", " + firstClerk.Job + ", " + firstClerk.City);
            }
            else
            {
                Console.WriteLine("No clerks have been found in the list.");
            }


            Console.WriteLine("\nSearching from the last: \n");

            List<Employee> result2 = employees.Where(emp => emp.Job == "Manager").ToList();
            Console.WriteLine(result2[result2.Count - 1].EmpID + ", " + result2[result2.Count - 1].EmpName + ", " + result2[result2.Count - 1].Job + ", " + result2[result2.Count - 1].City);

            //Using Last and LastOrDefault
            Employee lastManager = employees.Last(emp => emp.Job == "Manager");
            Console.WriteLine(lastManager.EmpID + ", " + lastManager.EmpName + ", " + lastManager.Job + ", " + lastManager.City);

            Employee lastClerk = employees.LastOrDefault(emp => emp.Job == "Clerk");
            if (lastClerk != null)
            {
                Console.WriteLine(lastClerk.EmpID + ", " + lastClerk.EmpName + ", " + lastClerk.Job + ", " + lastClerk.City);
            }
            else
            {
                Console.WriteLine("No clerks have been found in the list.");
            }

            Console.ReadKey();
        }
    }
}
