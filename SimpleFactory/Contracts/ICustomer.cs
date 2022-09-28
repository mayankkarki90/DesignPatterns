namespace Contracts
{
    public interface ICustomer
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNo { get; set; }

        public DateTime BillDate { get; set; }

        public double BillAmount { get; set; }

        void Validate();
    }
}