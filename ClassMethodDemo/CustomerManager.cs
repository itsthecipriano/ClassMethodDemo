using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddingCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname + " added to the system.");
        }

        public void ListingCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.CustomerName);
            Console.WriteLine(customer.CustomerSurname);
            Console.WriteLine(customer.Job);
            Console.WriteLine(customer.PhoneNumber);
        }
        
        public void DeletingCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.CustomerName + " " + customer.CustomerSurname + " deleted from the system.");
        }
    }
}
