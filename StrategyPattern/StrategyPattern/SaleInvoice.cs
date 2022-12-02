using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SaleInvoice
    {
        private readonly IDiscountStrategy _discountStrategy;

        public string CustomerName { get; set; }

        public double SaleAmount { get; set; }

        public SaleInvoice(IDiscountStrategy discountStrategy)
        {
            this._discountStrategy = discountStrategy;
        }

        public double GetFinalAmount()
        {
            return _discountStrategy.ApplyDiscount(SaleAmount);
        }
    }
}
