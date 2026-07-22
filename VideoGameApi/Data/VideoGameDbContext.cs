using Microsoft.EntityFrameworkCore;

namespace VideoGameApi.Data;

public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
{
    public DbSet<VideoGame> VideoGames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame
            {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Platform = "Nintendo Switch",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo"
            },
            new VideoGame
            {
                Id = 2,
                Title = "Grand Theft Auto V",
                Platform = "PC",
                Developer = "Rockstar North",
                Publisher = "Rockstar Games"
            },
            new VideoGame
            {
                Id = 3,
                Title = "Minecraft",
                Platform = "PC",
                Developer = "Mojang Studios",
                Publisher = "Microsoft"
            },
            new VideoGame
            {
                Id = 4,
                Title = "Elden Ring",
                Platform = "PlayStation 5",
                Developer = "FromSoftware",
                Publisher = "Bandai Namco Entertainment"
            },
            new VideoGame
            {
                Id = 5,
                Title = "Cyberpunk 2077",
                Platform = "PC",
                Developer = "CD Projekt Red",
                Publisher = "CD Projekt"
            }
        );
    }
}
