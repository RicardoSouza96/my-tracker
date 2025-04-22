using my_tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace my_tracker.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Manga> Mangas{ get; set; }
    public DbSet<Anime> Animes { get; set; }
    public DbSet<Game> Games { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manga>().ToTable("Mangas");
        modelBuilder.Entity<Anime>().ToTable("Animes");
        modelBuilder.Entity<Game>().ToTable("Games");
    }
}