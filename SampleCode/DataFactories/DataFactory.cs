using ADO.DAL;
using Contracts;
using DataContracts;
using Microsoft.Extensions.DependencyInjection;

namespace DataFactories
{
    public static class DataFactory<T> where T : class
    {
        static IServiceProvider serviceProvider = null;

        static string connectionString = @"Data Source=localhost\SQLEXPRESS;Database=DesignPatternDb;Integrated Security=True";

        public static T Create()
        {
            if (serviceProvider == null)
            {
                var services = new ServiceCollection()
                    .AddTransient<IDataRepository<ICustomer>>(x => new CustomerData(connectionString));
                serviceProvider = services.BuildServiceProvider();
            }

            return serviceProvider.GetService<T>();
        }
    }
}
