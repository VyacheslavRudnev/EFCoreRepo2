namespace BLL.Interfaces;

public interface IService<T> where T : class
{
    void Add(T item);
    void Remove(int id);
    void Update(T item, int id);
    List<T> GetAll();

}
