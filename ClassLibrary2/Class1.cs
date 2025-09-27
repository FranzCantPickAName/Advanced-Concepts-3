using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{

    //moodel class
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
    }

    public enum SortBy
    {
        EmpID, EmpName, Job
    }

    public class CustomComparer : IComparer<Employee>
    {
        //Sort by EmpID
        //public int Compare(Employee x, Employee y)
        //{
        //    return x.EmpID - y.EmpID;
        //}

        //Sort by EmpName
        //public int Compare(Employee x, Employee y)
        //{
        //    return x.EmpName.CompareTo(y.EmpName);
        //}

        //Sort By Job, EmpName
        //public int Compare(Employee x, Employee y)
        //{
        //    int result = 0;
        //    if (x.Job != null)
        //    {
        //        result = x.Job.CompareTo(y.Job); //first sorting column
        //    }
        //    if (result == 0)
        //    {
        //        if (x.EmpName != null)
        //        {
        //            result = x.EmpName.CompareTo(y.EmpName); //second sorting column
        //        }
        //    }
        //    return result;
        //}

        //Sort by selected column
        public int Compare(Employee x, Employee y)
        {
            int result = 0;
            switch (this.sortBy)
            {
                case SortBy.EmpID:
                    result = x.EmpID - y.EmpID; break;
                case SortBy.EmpName:
                    result = (x.EmpName != null) ? x.EmpName.CompareTo(y.EmpName) : 0; break;
                case SortBy.Job:
                    result = (x.Job != null) ? x.Job.CompareTo(y.Job) : 0; break;
                default:
                    result = 0; break;
            }
            return result;
        }

        public SortBy sortBy { get; set; }
    }

}

