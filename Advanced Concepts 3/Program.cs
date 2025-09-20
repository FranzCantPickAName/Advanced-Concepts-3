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
            student.RollNo = 123;
            student.StudentName = "Scott";
            student.Email = "scott@gmail.com";

            student.branch = new Branch();
            student.branch.BranchName = "Computer Science Engineering";
            student.branch.NoOfSemesters = 8;

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.StudentName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.branch.BranchName);
            Console.WriteLine(student.branch.NoOfSemesters);

            Console.ReadKey();
        }
    }
}
