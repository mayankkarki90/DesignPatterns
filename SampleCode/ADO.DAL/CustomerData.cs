using Contracts;
using Factories;

namespace ADO.DAL
{
    public class CustomerData : DataRepository<ICustomer>
    {
        public CustomerData(string connectionString) : base(connectionString)
        {
        }

        public override void ExecuteAddCommand(ICustomer obj)
        {
            Command.CommandText = "Insert into Customers (Name) Values ('" + obj.Name + "')";
            Command.ExecuteNonQuery();
        }

        public override List<ICustomer> ExecuteSearchCommand(string query)
        {
            Command.CommandText = "Select * from Customers";
            var reader = Command.ExecuteReader();
            var customers = new List<ICustomer>();
            while (reader.Read())
            {
                var customer = CustomerFactory.Create("Customer");
                customer.Name = reader["Name"].ToString() ?? "";
                customer.Address = reader["Address"].ToString() ?? "";
                customer.BillAmount = reader["BillAmount"] is DBNull ? 0 : Convert.ToDouble(reader["BillAmount"]);
                customer.PhoneNo = reader["PhoneNo"].ToString() ?? "";

                if (reader["BillDate"] is not DBNull)
                    customer.BillDate = Convert.ToDateTime(reader["BillDate"]);

                customers.Add(customer);
            }

            return customers;
        }
    }
}
