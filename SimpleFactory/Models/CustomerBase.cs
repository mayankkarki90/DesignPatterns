using Contracts;

namespace Models
{
    public class CustomerBase : ICustomer
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNo { get; set; }

        public DateTime BillDate { get; set; }

        public double BillAmount { get; set; }

        public virtual void Validate()
        {

        }
    }
}
