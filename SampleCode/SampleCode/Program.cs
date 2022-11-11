using Contracts;
using DataContracts;
using DataFactories;
using Factories;
using System;

namespace Models // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static Random random = new();

        static void Main(string[] args)
        {
            bool hasValidMenuInput = true;

            do
            {
                Console.WriteLine("Menu : ");
                Console.WriteLine("1. Generate a new customer");
                Console.WriteLine("2. Get all customers");
                Console.Write("Input number to select menu item : ");
                string userMenuInput = Console.ReadLine() ?? "";
                int.TryParse(userMenuInput, out int result);

                switch (result)
                {
                    case 1:
                        {
                            var newCustomer = GetNewCustomer();
                            AddCustomer(newCustomer);
                            ShowCustomer(newCustomer);
                            break;
                        }
                    case 2:

                        Console.WriteLine("All Customers : ");
                        foreach (var customer in SearchCustomer())
                        {
                            ShowCustomer(customer);
                        }
                        break;
                        
                    default:
                        hasValidMenuInput = false;
                        break;
                }

                Console.WriteLine();
            }
            while (hasValidMenuInput);
        }

        public static ICustomer GetNewCustomer()
        {
            var customer = CustomerFactory.Create("Customer");
            customer.Name = "Temp " + random.Next();
            customer.Validate();

            return customer;
        }

        public static void AddCustomer(ICustomer customer)
        {
            var customerData = DataFactory<IDataRepository<ICustomer>>.Create();
            customerData.Add(customer);
            Console.WriteLine("Customer Added");
        }

        public static List<ICustomer> SearchCustomer()
        {
            var customerData = DataFactory<IDataRepository<ICustomer>>.Create();
            return customerData.Search(string.Empty);
        }

        public static void ShowCustomer(ICustomer customer)
        {
            Console.WriteLine(customer.Name);
        }

        public static void ShowAllCustomer(IList<ICustomer> customers)
        {
            foreach (var customer in customers)
            {
                ShowCustomer(customer);
            }
        }
    }
}