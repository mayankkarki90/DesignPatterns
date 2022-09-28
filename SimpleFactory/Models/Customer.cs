namespace Models
{
    //For a custom type name and phone number are required to valdiate
    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            base.Validate();

            Console.WriteLine("Customer validated");
        }
    }
}
