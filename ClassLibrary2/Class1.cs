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
    public class CustomersList : ICollection<Customer>
    {
        //private collection as a field
        private List<Customer> customers = new List<Customer>();

        public int Count => customers.Count;

        public bool IsReadOnly => false;

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

        public void Clear()
        {
            customers.Clear();
        }

        public bool Contains(Customer item)
        {
            return customers.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            customers.CopyTo(array, arrayIndex);
        }

        public bool Remove(Customer item)
        {
            return customers.Remove(item);
        }

        public Customer Find(Predicate<Customer> match)
        {
            return customers.Find(match);
        }

        public List<Customer> FindAll(Predicate<Customer> match)
        {
            return customers.FindAll(match);
        }
    }

}
