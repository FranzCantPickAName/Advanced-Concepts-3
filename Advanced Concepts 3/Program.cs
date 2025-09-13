using ClassLibrary1;
using System;
using System.Linq.Expressions;

namespace EventsSample
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Student s = new Student() { StudentID = 101, StudentName = "Scott", Age = 15 };

            Expression<Func<Student, bool>> expression = st => st.Age > 12 && st.Age < 20;

            Func<Student, bool> myDelegate = expression.Compile();

            bool result = myDelegate.Invoke(s);
            Console.WriteLine(result);

            Console.ReadKey();
        }

            
            
            }
}