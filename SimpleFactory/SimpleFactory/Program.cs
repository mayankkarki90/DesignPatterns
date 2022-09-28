using Contracts;
using Factories;
using System;

namespace Models // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomer customer;

            Console.Write("Type of customer, 'Customer' or 'Lead'");
            string customerType = Console.ReadLine() ?? "";
            customer = CustomerFactory.Create(customerType);
            customer.Validate();
        }
    }
}