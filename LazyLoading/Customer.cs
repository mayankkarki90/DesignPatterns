using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    internal class Customer
    {
        private List<Order> _orders;

        public string Name { get; set; }

        public List<Order> Orders
        {
            get
            {
                //way of adding manual lazy loading
                if (_orders == null)
                {
                    _orders = GetOrders();
                }

                return _orders;
            }
        }

        public Customer()
        {
            Name = "James Smith";

            //It is not good to load large set of data in constructor or unnecessarily until the point it needed
            //_orders = GetOrders();

            
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
