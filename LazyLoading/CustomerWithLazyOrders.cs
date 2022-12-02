using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    internal class CustomerWithLazyOrders
    {
        private Lazy<List<Order>> _orders;

        public string Name { get; set; }

        public List<Order> Orders
        {
            get
            {
                return _orders.Value;
            }
        }

        public bool IsOrderCreated => _orders.IsValueCreated;

        public CustomerWithLazyOrders()
        {
            Name = "James Smith";

            _orders = new Lazy<List<Order>>(() => GetOrders());


        }

        public List<Order> GetOrders()
        {
            var tempOrders = new List<Order>();
            tempOrders.Add(new Order { Id = 1, Amount = 100 });
            tempOrders.Add(new Order { Id = 2, Amount = 200 });

            return tempOrders;
        }
    }
}
