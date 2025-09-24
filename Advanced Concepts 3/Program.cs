using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            CustomersList customersList = new CustomersList()
            {
                new Customer() { CustomerID = "A101", CustomerName = "James", Email = "james@gmail.com", CustomerType = TypeOfCustomer.RegularCustomer },
                new Customer() { CustomerID = "A201", CustomerName = "Bob", Email = "bob@gmail.com", CustomerType = TypeOfCustomer.VIPCustomer },
                new Customer() { CustomerID = "A301", CustomerName = "Alice", Email = "alice@gmail.com", CustomerType = TypeOfCustomer.VIPCustomer }
            };

            Customer new_cust = new Customer() { CustomerID = "A456", CustomerName = "Jacob", Email = "jacob@gmail.com", CustomerType = TypeOfCustomer.VIPCustomer };
            customersList.Add(new_cust);

            foreach (Customer customer in customersList)
            {
                Console.WriteLine(customer.CustomerID + ", " + customer.CustomerName + ", " + customer.Email + ", " + customer.CustomerType);
            }

            Console.WriteLine();
            Console.WriteLine("Contains: " + customersList.Contains(new_cust));
            Console.WriteLine(customersList.Count + " customers found.");

            customersList.Remove(new_cust);
            foreach (Customer customer in customersList)
            {
                Console.WriteLine(customer.CustomerID + ", " + customer.CustomerName + ", " + customer.Email + ", " + customer.CustomerType);
            }

            Customer matchingCustomer = customersList.Find(cust => cust.CustomerID == "A101");
            if (matchingCustomer != null)
            {
                Console.WriteLine(matchingCustomer.CustomerID + ", " + matchingCustomer.CustomerName);
            }

            List<Customer> vipcust = customersList.FindAll(cust => cust.CustomerType == TypeOfCustomer.VIPCustomer);
            Console.WriteLine("\nVIP customers: ");
            foreach (Customer customer in vipcust)
            {
                Console.WriteLine(customer.CustomerID + ", " + customer.CustomerName + ", " + customer.Email + ", " + customer.CustomerType);
            }

            //IndexOf
            Console.WriteLine("IndexOf: " + customersList.IndexOf(new_cust));

            //Insert
            customersList.Insert(2, new_cust);
            Console.WriteLine(customersList[2].CustomerID + ", " + customersList[2].CustomerName);

            customersList.RemoveAt(1);

            foreach (Customer customer in customersList)
            {
                Console.WriteLine(customer.CustomerID + ", " + customer.CustomerName + ", " + customer.Email + ", " + customer.CustomerType);
            }

            customersList.Clear();

            Console.ReadKey();
        }
    }
}
