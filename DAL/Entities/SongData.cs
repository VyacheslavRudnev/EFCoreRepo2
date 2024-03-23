namespace DAL.Entities;

public class SongData
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public string Genre { get; set; }
    public AuthorData Author { get; set; }
}
