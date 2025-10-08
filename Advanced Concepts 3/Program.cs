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
                new Employee() { EmpID = 101, EmpName = "Henry", Job = "Designer", City = "Boston", Salary = 100000 },
                new Employee() { EmpID = 102, EmpName = "Jack", Job = "Developer", City = "New York", Salary = 150000 },
                new Employee() { EmpID = 103, EmpName = "Gabriel", Job = "Analyst", City = "Tokyo", Salary = 300000 },
                new Employee() { EmpID = 104, EmpName = "William", Job = "Manager", City = "Tokyo", Salary = 400000 },
                new Employee() { EmpID = 105, EmpName = "Alexa", Job = "Manager", City = "New York", Salary = 200000 }
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

            //Using Where
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

            //ElementAt
            Console.WriteLine("\nSearching at element: \n");

            Employee resultEmp = employees.Where(emp => emp.Job == "Manager").ElementAt(1);
            Console.WriteLine(resultEmp.EmpID + ", " + resultEmp.EmpName + ", " + resultEmp.Job + ", " + resultEmp.City);

            Employee resultEmp2 = employees.Where(emp => emp.Job == "Manager").ElementAtOrDefault(4);
            if (resultEmp2 != null)
            {
                Console.WriteLine(resultEmp2.EmpID + ", " + resultEmp2.EmpName + ", " + resultEmp2.Job + ", " + resultEmp2.City);
            }
            else
            {
                Console.WriteLine("No managers found at index 4.");
            }

            //Single
            //Either method will throw an exception if more than 1 matching element is found
            Console.WriteLine("\nSearching for single element: \n");

            Employee singleResult = employees.Single(emp => emp.EmpID == 102);
            Console.WriteLine(singleResult.EmpID + ", " + singleResult.EmpName + ", " + singleResult.Job + ", " + singleResult.City);

            Employee singleResult2 = employees.SingleOrDefault(emp => emp.Job == "Clerk");
            if (singleResult2 != null)
            {
                Console.WriteLine(singleResult2.EmpID + ", " + singleResult2.EmpName + ", " + singleResult2.Job + ", " + singleResult2.City);
            }
            else
            {
                Console.WriteLine("No matching employee.");
            }

            //Select
            Console.WriteLine("\nListing employees as Person(s): \n");

            List<Person> people = employees.Select(emp => new Person() { PersonName = emp.EmpName }).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine(person.PersonName);
            }

            Console.WriteLine();
            //Min, Max, Sum, Avg, Count
            Console.WriteLine("The employee with the lowest salary earns: " + employees.Min(emp => emp.Salary));
            Console.WriteLine("The employee with the highest salary earns: " + employees.Max(emp => emp.Salary));
            Console.WriteLine("The sum of all employee salaries is: " + employees.Sum(emp => emp.Salary));
            Console.WriteLine("The avergae salary is: " + employees.Average(emp => emp.Salary));
            Console.WriteLine("The total number of employees is: " + employees.Count());

            Console.ReadKey();
        }
    }
}
