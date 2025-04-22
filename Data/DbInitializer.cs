using my_tracker.Models;

namespace my_tracker.Data;

public class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();
        
        if (context.Animes.Any() || context.Mangas.Any() || context.Games.Any())
        {
            return;
        }

        var mangas = new Manga[]
        {
            new Manga {
                Id = 1,
                Title = "Naruto",
                Author = "Masashi Kishimoto",
                Status = "Completed",
                StartDate = new DateOnly(2002, 10, 3),
                EndDate = new DateOnly(2014, 2, 8)
            },
            new Manga {
                Id = 2,
                Title = "One Piece",
                Author = "Eiichiro Oda",
                Status = "Ongoing",
                StartDate = new DateOnly(1997, 7, 22),
                EndDate = null
            },
            new Manga {
                Id = 3,
                Title = "Attack on Titan",
                Author = "Hajime Isayama",
                Status = "Completed",
                StartDate = new DateOnly(2009, 9, 9),
                EndDate = new DateOnly(2021, 4, 9)
            }
        };

        var animes = new Anime[]
        {
            new Anime {
                Id = 1,
                Title = "Naruto",
                Author = "Masashi Kishimoto",
                Status = "Completed",
                StartDate = new DateOnly(2002, 10, 3),
                EndDate = new DateOnly(2014, 2, 8)
            },

            new Anime {
                Id = 2,
                Title = "Attack on Titan",
                Author = "Hajime Isayama",
                Status = "Completed",
                StartDate = new DateOnly(2009, 9, 9),
                EndDate = new DateOnly(2021, 4, 9)
            }
        };

        var games = new Game[]
        {
            new Game {
                Id = 1,
                Title = "The Legend of Zelda: Breath of the Wild",
                Platform = "Nintendo Switch",
                Status = "Completed",
                LaunchDate = new DateOnly(2017, 3, 3)
            },
            new Game {
                Id = 2,
                Title = "The Witcher 3: Wild Hunt",
                Platform = "PS4",
                Status = "Completed",
                LaunchDate = new DateOnly(2015, 5, 19)
            }
        };

        context.Mangas.AddRange(mangas);
        context.Animes.AddRange(animes);
        context.Games.AddRange(games);

        context.SaveChanges();
    }
}
