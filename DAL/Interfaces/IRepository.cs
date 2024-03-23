namespace DAL.Interfaces;

public interface IRepository<T> where T : class
{
    void Add(T item);
    void Remove(int id);
    void Update(T item, int id);
    List<T> GetAll();
    List<T> Get(int count);
}
