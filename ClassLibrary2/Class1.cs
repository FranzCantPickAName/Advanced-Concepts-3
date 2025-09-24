using System;
using System.Collections.Generic;

namespace ClassLibrary1
{

    /// <summary>
    /// Represents a student
    /// </summary>
    public class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        //public Branch branch {  get; set; }
        public List<Examination> examinations { get; set; }
    }

    //public class Branch
    //{
    //    public string BranchName { get; set; }
    //    public int NoOfSemesters { get; set; }
    //}

    /// <summary>
    /// Represents examination attempted by student
    /// </summary>
    public class Examination
    {
        public string ExaminationName { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int MaxMarks { get; set; }
        public int SecuredMarks { get; set; }
    }

}
