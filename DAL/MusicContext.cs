using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class MusicContext : DbContext
{
    public DbSet<AuthorData> Author { get; set; }
    public DbSet<SongData> Song { get; set; }
    public DbSet<PlaylistData> Playlist { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("MyDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //var author = modelBuilder.Entity<AuthorData>();
        //author.HasIndex(x => x.Name).IsUnique();
        //author.Property(x => x.Name).IsRequired(false);
        
        //author.Ignore(x => x.SongsCount);
        //author.Property(x => x.Name).HasMaxLength(32);

        //author.HasMany(author => author.Songs).WithOne();

        //var song = modelBuilder.Entity<SongData>();
        //song.HasOne(song => song.Author).WithMany();

        var user = modelBuilder.Entity<UserData>();
        user.Property(x => x.Name).IsRequired();
        user.Property(x => x.Name).HasMaxLength(32);

        user.Property(x => x.Login).IsRequired();
        user.Property(x => x.Login).HasMaxLength(64);
        user.Property(x => x.Login).IsUnicode();

        user.Property(x =>x.Password).IsRequired();
        user.Property(x => x.Password).HasMaxLength(64);

        user.Property(x =>x.Role).IsRequired(false);
    }

    
}
