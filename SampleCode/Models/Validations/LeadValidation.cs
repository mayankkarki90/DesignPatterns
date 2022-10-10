using Contracts;

namespace Entities.Validations
{
    public class LeadValidation : IValidation
    {
        public void Validate(ICustomer customer)
        {
            Console.WriteLine("Lead Validate");
        }
    }
}
