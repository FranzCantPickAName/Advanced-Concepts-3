using ClassLibrary1;
using System;
using System.Text;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Person person1 = new Person();

            person1.PersonName = "Miller";
            person1.DateOfBirth = DateTime.Parse("2000-12-31 11:59:59.999 am");
            Console.WriteLine(person1.DateOfBirth.ToString());

            Console.WriteLine("Day " + person1.DateOfBirth.Day);
            Console.WriteLine("Month " + person1.DateOfBirth.Month);
            Console.WriteLine("Year " + person1.DateOfBirth.Year);
            Console.WriteLine("Hours " + person1.DateOfBirth.Hour);
            Console.WriteLine("Minutes " + person1.DateOfBirth.Minute);
            Console.WriteLine("Seconds " + person1.DateOfBirth.Second);
            Console.WriteLine("Milliseconds " + person1.DateOfBirth.Millisecond);
            Console.WriteLine("Day of week " + person1.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of week (as int) " + (int)person1.DateOfBirth.DayOfWeek);
            Console.WriteLine("Day of year " + person1.DateOfBirth.DayOfYear);
            Console.WriteLine("Days in month " + DateTime.DaysInMonth(person1.DateOfBirth.Year, person1.DateOfBirth.Month));

            Console.WriteLine();
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString());

            Console.WriteLine();
            DateTime dt2 = new DateTime(2025, 10, 1, 0, 0, 0, 000);

            Console.WriteLine(dt2.ToString());
            Console.WriteLine(dt2.ToShortDateString());
            Console.WriteLine(dt2.ToLongDateString());
            Console.WriteLine(dt2.ToShortTimeString());
            Console.WriteLine(dt2.ToLongTimeString());
            Console.WriteLine(dt2.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(DateTime.DaysInMonth(dt2.Year, dt2.Month));
            Console.WriteLine(DateTime.IsLeapYear(dt2.Year));


            Console.ReadKey();
        }
    }
}
