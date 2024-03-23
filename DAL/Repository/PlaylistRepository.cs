using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repository;

public class PlaylistRepository : GenericRepository<PlaylistData>
{
    public PlaylistRepository() : base()
    {
    }
}

