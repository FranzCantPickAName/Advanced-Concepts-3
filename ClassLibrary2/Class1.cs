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
        public string Email {  get; set; }
        public TypeOfCustomer CustomerType { get; set; }

    }

    public class CustomerList : IEnumerable
    {
        private List<Customer> customers = new List<Customer>();
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                yield return customers[i];
            }
        }

        public void Add(Customer cust)
        {
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
