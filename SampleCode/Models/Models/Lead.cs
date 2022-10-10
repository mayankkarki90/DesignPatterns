using Contracts;

namespace Entities.Models
{
    //For a lead type customer no validation is required
    public class Lead : CustomerBase
    {
        public Lead(IValidation validation) : base(validation)
        {
        }
    }
}
