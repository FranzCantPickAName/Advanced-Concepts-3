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
            CustomerList customersList = new CustomerList()
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

            Console.ReadKey();
        }
    }
}
