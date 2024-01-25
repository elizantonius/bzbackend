namespace bzbackend.Repository
{
    public interface IRepository<T> where T : class
    {
        ICollection<T> Get();
        Task<T> GetById(int id);
        Task<T> Post(T value);
        Task<bool> Put(int id, T value);
        Task<bool> Delete(int id);
    }
}




