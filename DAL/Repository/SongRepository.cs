using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository;

public class SongRepository : GenericRepository<SongData>
{
    public SongRepository() : base()
    {
        var author = _musicContext.Author.Add(new AuthorData()
        {
            Name = "John",
        });

        Add(new SongData {
            Title = "Song1",
            Duration = 180,
            Genre = "Pop",
            Author = author.Entity
        });

        _musicContext.SaveChanges();
    }

    public override List<SongData> GetAll()
    {
        return _musicContext.Song
            .Include(x => x.Author)
            .ToList();
    }
}
