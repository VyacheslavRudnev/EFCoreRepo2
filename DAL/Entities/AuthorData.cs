using System.ComponentModel.DataAnnotations;

namespace DAL.Entities;

public class AuthorData
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<SongData> Songs { get; set; }
    public int SongsCount => Songs.Count();
}
