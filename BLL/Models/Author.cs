namespace BLL.Models;

public class Author
{
    public int Id { get; set; }

    public string Name { get; set; }
    public List<Song> Songs { get; set; } = new();

    public override string ToString()
    {
        return $"{Name}, {Songs.Count} songs";
    }
}
