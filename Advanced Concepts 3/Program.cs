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
            Student student = new Student();
            student.RollNo = 1;
            student.StudentName = "Allen";
            student.Email = "allen@gmail.com";

            student.examinations = new List<Examination>();
            student.examinations.Add(new Examination() { ExaminationName = "Module Test 1", Month = 5, Year = 2021, MaxMarks = 100, SecuredMarks = 87 });
            student.examinations.Add(new Examination() { ExaminationName = "Module Test 2", Month = 7, Year = 2022, MaxMarks = 100, SecuredMarks = 70 });
            student.examinations.Add(new Examination() { ExaminationName = "Final Test", Month = 11, Year = 2023, MaxMarks = 100, SecuredMarks = 91 });

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine("Examinations:");
            foreach (Examination exam in student.examinations)
            {
                Console.WriteLine(exam.ExaminationName + ", " + exam.Year + ", " + exam.Month + ", " + exam.SecuredMarks + "/" + exam.MaxMarks);
            }

            Console.ReadKey();
        }
    }
}
