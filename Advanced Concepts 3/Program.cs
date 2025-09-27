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
            Customer customer = new Customer();

            //Without deconstruction
            //(int customerID, string customerName, string email) cust = customer.GetCustomerDetails();

            //Console.WriteLine(cust.customerID);
            //Console.WriteLine(cust.customerName);
            //Console.WriteLine(cust.email);

            //With deconstruction
            (int customerID, string customerName, string email) = customer.GetCustomerDetails();

            Console.WriteLine(customerID);
            Console.WriteLine(customerName);
            Console.WriteLine(email);

            Console.ReadKey();
        }
    }
}
