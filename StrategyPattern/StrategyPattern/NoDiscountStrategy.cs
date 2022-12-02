using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class NoDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(double amount)
        {
            return amount;
        }
    }
}
