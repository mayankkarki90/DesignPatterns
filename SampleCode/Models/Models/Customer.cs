using Contracts;

namespace Entities.Models
{
    //For a custom type name and phone number are required to valdiate
    public class Customer : CustomerBase
    {
        public Customer(IValidation validation) : base(validation)
        {
        }
    }
}
