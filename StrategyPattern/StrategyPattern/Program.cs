// See https://aka.ms/new-console-template for more informationusing System;

namespace StrategyPattern // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("Customer Name : ");
                string customerName = Console.ReadLine() ?? "Default";

                Console.Write("Bill Amount : ");
                double billAmount = Convert.ToDouble(Console.ReadLine());

                SaleInvoice invoice;
                //Design Pattern : Strategy, defines family of algorithms and each one can be
                //used interchangibly. 
                switch (DateTime.Today.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        invoice = new SaleInvoice(new LowDiscountStrategy());
                        break;
                    case DayOfWeek.Friday:
                        invoice = new SaleInvoice(new HighDiscountStrategy());
                        break;
                    default:
                        invoice = new SaleInvoice(new NoDiscountStrategy());
                        break;
                }

                invoice.CustomerName = customerName;
                invoice.SaleAmount = billAmount;
                Console.WriteLine("Final Amount : " + invoice.GetFinalAmount());
                Console.WriteLine();
                Console.WriteLine("Press E to exit");                
            } while (Console.ReadLine() != "E");
        }
    }
}
