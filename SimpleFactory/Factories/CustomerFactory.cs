using Contracts;
using Models;

namespace Factories
{
    public static class CustomerFactory // Design Pattern : Simple Factory pattern
    {
        private static readonly Lazy<Dictionary<string, ICustomer>> _customerLazyList;

        public static Dictionary<string, ICustomer> Customers => _customerLazyList.Value;

        static CustomerFactory()
        {
            _customerLazyList = new Lazy<Dictionary<string, ICustomer>>(() => GetCustomers());
        }

        private static Dictionary<string, ICustomer> GetCustomers()
        {
            Dictionary<string, ICustomer> tempCustomers = new()
            {
                { "Customer", new Customer() },
                { "Lead", new Lead() }
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
            return Customers[customerType];
        }
    }
}
