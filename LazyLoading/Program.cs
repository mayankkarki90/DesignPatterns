using LazyLoading;

public class Program
{
    public static void Main(string[] args)
    {
        //    Customer customer = new Customer();
        //    Console.WriteLine(customer.Name);
        //    foreach(var order in customer.Orders)
        //    {
        //        Console.WriteLine($"Order {order.Id} : {order.Amount}");
        //    }

        //You cannot check lazy list with debugging, because by hovering the value
        //you trigger the lazy operation.
        //use IsValueCreated to check whether list is loaded or not
        CustomerWithLazyOrders customer = new CustomerWithLazyOrders();
        Console.WriteLine(customer.Name);
        Console.WriteLine("Orders created : " + customer.IsOrderCreated);

        foreach (var order in customer.Orders)
        {
            Console.WriteLine($"Order {order.Id} : {order.Amount}");
        }

    }
}
