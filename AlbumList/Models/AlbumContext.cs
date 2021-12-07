//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AlbumList.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options)
            : base(options)
        { }

        public DbSet<ListensModel> Listens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListensModel>().HasData(
                new ListensModel
                {
                    ListensModelId = 1,
                    Title = "Ivy",
                    Album = "Blonde",
                    Artist = "Frank Ocean",
                    Rating = 6
                },
                new ListensModel
                {
                    ListensModelId = 2,
                    Title = "#3",
                    Album = "Selected Ambient Works Volume II",
                    Artist = "Aphex Twin",
                    Rating = 3
                },
                new ListensModel
                {
                    ListensModelId = 3,
                    Title = "Fake Plastic Trees",
                    Album = "The Bends",
                    Artist = "Radiohead",
                    Rating = 9
                },
                new ListensModel
                {
                    ListensModelId = 4,
                    Title = "Kickback",
                    Album = "Kickback",
                    Artist = "KanKan",
                    Rating = 5
                },
                new ListensModel
                {
                    ListensModelId = 5,
                    Title = "Everyday",
                    Album = "After Me",
                    Artist = "SoFaygo",
                    Rating = 6
                },
                new ListensModel
                {
                    ListensModelId = 6,
                    Title = "Kiss Me Like It's the First Time",
                    Album = "Let's Skip to the Wedding",
                    Artist = "Eyedress",
                    Rating = 1
                }
           );
        }
    }
}
