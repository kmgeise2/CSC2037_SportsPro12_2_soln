namespace CSC2037_SportsPro12_2_soln.Models
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);

        // overloaded Get() method
        T? Get(QueryOptions<T> options);
        T? Get(int id);
        T? Get(string id);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);

        void Save();
    }
}
