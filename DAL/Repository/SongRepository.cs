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

        Add(new SongData
        {
            Title = "Song2",
            Duration = 170,
            Genre = "Pop",
            Author = author.Entity
        });

        Add(new SongData
        {
            Title = "Song3",
            Duration = 160,
            Genre = "Pop",
            Author = author.Entity
        });

        Add(new SongData
        {
            Title = "Song4",
            Duration = 150,
            Genre = "Pop",
            Author = author.Entity
        });

        Add(new SongData
        {
            Title = "Song5",
            Duration = 220,
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
