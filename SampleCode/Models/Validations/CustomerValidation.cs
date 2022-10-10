using Contracts;

namespace Entities.Validations
{
    public class CustomerValidation : IValidation
    {
        public void Validate(ICustomer customer)
        {
            Console.WriteLine("Customer validated");
        }
    }
}
