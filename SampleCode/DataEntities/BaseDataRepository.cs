using DataContracts;

namespace DataEntities
{
    public abstract class BaseDataRepository<T> : IDataRepository<T> where T : class
    {
        protected string ConnectionString { get; }

        public BaseDataRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public virtual void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> Search(string query)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}