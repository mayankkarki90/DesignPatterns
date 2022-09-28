namespace Models
{
    //For a lead type customer no validation is required
    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            base.Validate();

            Console.WriteLine("Lead validated");
        }
    }
}
