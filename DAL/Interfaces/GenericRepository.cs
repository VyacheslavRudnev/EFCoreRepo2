
namespace DAL.Interfaces;

public abstract class GenericRepository<T> : IRepository<T> where T : class
{
    protected readonly MusicContext _musicContext;

    public GenericRepository()
    {
        _musicContext = new MusicContext();
    }

    public void Add(T item)
    {
        _musicContext.Set<T>().Add(item);
        _musicContext.SaveChanges();
    }

    public virtual List<T> GetAll()
    {
        return _musicContext.Set<T>().ToList();
    }

    public void Remove(int id)
    {
        T item = _musicContext.Set<T>().Find(id) ??
            throw new ArgumentNullException();

        _musicContext.Set<T>().Remove(item);
        _musicContext.SaveChanges();
    }

    public void Update(T item, int id)
    {
        T oldItem = _musicContext.Set<T>().Find(id) ??
            throw new ArgumentNullException();

        oldItem = item;
        _musicContext.SaveChanges();
    }

    public List<T> Get(int count)
    {
        return _musicContext.Set<T>().Take(count).ToList();
    }
}
