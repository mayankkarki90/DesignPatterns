using Contracts;

namespace Entities.Models
{
    public class CustomerBase : ICustomer
    {
        private readonly IValidation _validation;

        public CustomerBase(IValidation validation)
        {
            _validation = validation;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNo { get; set; }

        public DateTime BillDate { get; set; }

        public double BillAmount { get; set; }

        public void Validate()
        {
            _validation.Validate(this);
        }
    }
}
