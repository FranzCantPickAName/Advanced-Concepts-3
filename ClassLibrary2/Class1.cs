namespace ClassLibrary1
{
    public class Sample
    {
        public int GetNumber()
        {
            return 10;
        }
        public double GetAnotherNumber()
        {
            return 10.7;
        }
        public string GetMessage()
        {
            return "Hello";
        }
        public Employee GetEmployee()
        {
            return new Employee() { EmployeeName = "Scott" };
        }

    }

    public class Employee
    {
        public string EmployeeName { get; set; }

    }

}
