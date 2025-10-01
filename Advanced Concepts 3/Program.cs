using ClassLibrary1;
using System;
using System.Text;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Employee emp = new Employee() { EmployeeName = "John", DateOfJoining = DateTime.Parse("2015-01-01") };

            DateTime today = DateTime.Now;
            if (today.CompareTo(emp.DateOfJoining) == 1)
            {
                TimeSpan ts = today.Subtract(emp.DateOfJoining);
                emp.ExperienceYears = Math.Floor(ts.TotalDays / 365);
                emp.ExperienceMonths = Math.Floor((ts.TotalDays - (emp.ExperienceYears * 365)) / 30);
                Console.WriteLine(emp.ExperienceYears + " years and " + emp.ExperienceMonths + " months of experience");
            }
            else
            {
                Console.WriteLine("Date of joining is not before today's date, employee experience is zero.");
            }

            Console.WriteLine("After 10 days: " + emp.DateOfJoining.AddDays(10));
            Console.WriteLine("Before 10 days: " + emp.DateOfJoining.AddDays(-10));
            Console.WriteLine("After 20 months and 5 days: " + emp.DateOfJoining.AddMonths(20).AddDays(5));


                Console.ReadKey();
        }
    }
}
