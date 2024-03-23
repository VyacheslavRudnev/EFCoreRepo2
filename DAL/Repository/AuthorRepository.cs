using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repository;

public class AuthorRepository : GenericRepository<AuthorData>
{
    public AuthorRepository() : base()
    {
    }
}
