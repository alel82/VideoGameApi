using Microsoft.EntityFrameworkCore;
using VideoGameApi.Models;

namespace VideoGameApi.Data;

public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
{
    public DbSet<VideoGame> VideoGames { get; set; }

    public DbSet<VideoGameDetails> VideoGameDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Platform = "Nintendo Switch",
            },
            new VideoGame
            {
                Id = 2,
                Title = "Grand Theft Auto V",
                Platform = "PC",
            },
            new VideoGame
            {
                Id = 3,
                Title = "Minecraft",
                Platform = "PC",
            },
            new VideoGame
            {
                Id = 4,
                Title = "Elden Ring",
                Platform = "PlayStation 5",
            },
            new VideoGame
            {
                Id = 5,
                Title = "Cyberpunk 2077",
                Platform = "PC",
            }
        );
    }
}
