using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{

    public enum TypeOfCustomer
    {
        RegularCustomer, VIPCustomer
    }
    public class Customer : IEquatable<Customer>
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public TypeOfCustomer CustomerType { get; set; }

        public bool Equals(Customer other)
        {
            return this.CustomerID == other.CustomerID && this.CustomerName == other.CustomerName && this.Email == other.Email && this.CustomerType == other.CustomerType;
        }
    }


    //custom collection class
    public class CustomersList : IList<Customer>
    {
        //private collection as a field
        private List<Customer> customers = new List<Customer>();

        public int Count => customers.Count;

        public bool IsReadOnly => false;

        public Customer this[int index]
        {
            get => customers[index];
            set => customers[index] = value;
        }

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

        public int IndexOf(Customer item)
        {
            return customers.IndexOf(item);
        }

        public void Insert(int index, Customer item)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                customers.Insert(index, item);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                customers.RemoveAt(index);
            }
        }
    }

}
