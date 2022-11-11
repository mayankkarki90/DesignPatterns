using Contracts;
using Entities.Models;
using Entities.Validations;
using System;

namespace Factories
{
    public static class CustomerFactory // Design Pattern : Simple Factory pattern
    {
        private static readonly Lazy<Dictionary<string, Func<ICustomer>>> _customerLazyList;

        private static Dictionary<string, Func<ICustomer>> Customers => _customerLazyList.Value;

        static CustomerFactory()
        {
            //lazy loading
            _customerLazyList = new Lazy<Dictionary<string, Func<ICustomer>>>(() => GetCustomers());
        }

        private static Dictionary<string, Func<ICustomer>> GetCustomers()
        {
            Dictionary<string, Func<ICustomer>> tempCustomers = new()
            {
                { "Customer", () => new Customer(new CustomerValidation()) }, //Design Pattern : Strategy, helps to choose algorithms dynamically
                { "Lead", () => new Lead(new LeadValidation()) }
            };

            return tempCustomers;
        }

        public static ICustomer Create(string customerType)
        {
            //Design Pattern : RIP , Replace If with polymorphism
            //if (customerType == "Customer")
            //{
            //    return new Customer();
            //}
            //else
            //{
            //    return new Lead();
            //}

            //Design Pattern : Lazy loading, load only when objects are needed
            return Customers[customerType].Invoke();
        }
    }
}
