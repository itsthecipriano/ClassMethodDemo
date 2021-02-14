using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "İrem";
            customer1.CustomerSurname = "Deniz";
            customer1.Job = "Graphic Designer";
            customer1.PhoneNumber = 05351231212;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "Tuna";
            customer2.CustomerSurname = "Deniz";
            customer2.Job = "Pilot";
            customer2.PhoneNumber = 05353211212;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.CustomerName = "Zeynep";
            customer3.CustomerSurname = "Deniz";
            customer3.Job = "English Teacher";
            customer3.PhoneNumber = 05352131212;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddingCustomer(customer1);
            customerManager.DeletingCustomer(customer2);
            customerManager.ListingCustomer(customer3);



        }
    }
}
