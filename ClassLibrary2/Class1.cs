using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{

    public enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public TypeOfCustomer CustomerType { get; set; }

    }

    //public class CustomerList : IEnumerable
    //{
    //    private List<Customer> customers = new List<Customer>();
    //    public IEnumerator GetEnumerator()
    //    {
    //        for (int i = 0; i < customers.Count; i++)
    //        {
    //            yield return customers[i];
    //        }
    //    }

    //    public void Add(Customer cust)
    //    {
    //        if (cust.CustomerID.StartsWith("A") || cust.CustomerID.StartsWith("a"))
    //        {
    //            customers.Add(cust);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid Customer ID");
    //        }

    //    }



    //}

    //custom collection class
    public class CustomersList : IEnumerable<Customer>
    {
        //private collection as a field
        private List<Customer> customers = new List<Customer>();

        //implementing IEnumerable.GetEnumerator()
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //implementing IEnumerable<T>.GetEnumerator()
        public IEnumerator<Customer> GetEnumerator()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i]; //return and pause
            }
        }

        //Add with validations
        public void Add(Customer cust)
        {
            //validation
            if (cust.CustomerID.StartsWith("A") || cust.CustomerID.StartsWith("a"))
            {
                customers.Add(cust);
            }
            else
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }
    }

}
