using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{

    //moodel class
    public class Employee : IComparable
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }

        //Sort by EmpID(int)
        public int CompareTo(object other)
        {
            Employee otherEmp = (Employee)other;
            Console.WriteLine("Comparing " + this.EmpID + " with " + otherEmp.EmpID);
            return this.EmpID - otherEmp.EmpID;  //returns 0, -1 or 1
        }

        //Sort by EmpName (string)
        //public int CompareTo(object other)
        //{
        //    Employee otherEmp = (Employee)other;
        //    Console.WriteLine(this.EmpName + ", " + otherEmp.EmpName);
        //    return this.EmpName.CompareTo(otherEmp.EmpName);  //returns 0, -1 or 1
        //}

    }

}