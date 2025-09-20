using System;

namespace ClassLibrary1
{

    /// <summary>
    /// Represents a product in the ECommerce application
    /// </summary>
    public class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public Branch branch {  get; set; }

    }

    public class Branch
    {
        public string BranchName { get; set; }
        public int NoOfSemesters { get; set; }
    }

}
