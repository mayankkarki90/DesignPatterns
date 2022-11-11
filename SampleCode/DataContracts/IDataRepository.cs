namespace DataContracts
{
    //Design Pattern : Repository Pattern, whole goal of pattern is for decoupling dal from models
    // first create a inteface, and all client will consume this interface
    // then create a common abstract class for dal
    // create a dal class with all the data logic
    public interface IDataRepository<T> where T : class
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(T obj);

        List<T> Search(string query);

    }
}
