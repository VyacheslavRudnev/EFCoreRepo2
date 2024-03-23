
using DAL.Interfaces;

namespace BLL.Interfaces;

public abstract class GenericService<T> : IService<T> where T : class
{
    private readonly GenericRepository<T> _repository;

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public List<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(T item, int id)
    {
        throw new NotImplementedException();
    }

    public List<T> Get(int count)
    { 
        throw new NotImplementedException(); 
    }
}
