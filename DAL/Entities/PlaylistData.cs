namespace DAL.Entities;

public class PlaylistData
{
    public int Id { get; set; }
    public string NamePL { get; set; }
    public ICollection<SongData> Songs { get; set; }
    public AuthorData Author { get; set; }
}
