using DataEntities;
using System.Data.SqlClient;

namespace ADO.DAL
{
    public abstract class DataRepository<T> : BaseDataRepository<T> where T : class
    {
        SqlConnection? connection = null;
        protected SqlCommand Command;

        public DataRepository(string connectionString) : base(connectionString)
        {
        }

        public abstract void ExecuteAddCommand(T obj);

        public abstract List<T> ExecuteSearchCommand(string query);

        private void Open()
        {
            connection = new SqlConnection(ConnectionString);
            connection.Open();
            Command = new SqlCommand
            {
                Connection = connection
            };
        }       

        private void Close()
        {
            connection?.Close();
        }

        //Design Pattern : Template, A template is used to defined the structure or sequence
        //and child class is used to define how the sequence will behave.
        public override void Add(T obj)
        {
            Open();
            ExecuteAddCommand(obj);
            Close();
        }   

        public override List<T> Search(string query)
        {
            Open();
            var result = ExecuteSearchCommand(query);
            Close();

            return result;
        }
    }
}