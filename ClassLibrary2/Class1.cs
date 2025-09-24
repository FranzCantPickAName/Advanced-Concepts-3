using System;
using System.Collections.Generic;

namespace ClassLibrary1
{

    /// <summary>
    /// Represents an employee
    /// </summary>
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public Department dept {  get; set; }
    }


    /// <summary>
    /// Represents a department
    /// </summary>
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }

}
