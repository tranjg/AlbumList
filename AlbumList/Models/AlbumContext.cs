//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace AlbumList.Models
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options)
            : base(options)
        { }

        public DbSet<Album> Albums { get; set; }

        public DbSet<ListensModel> Listens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    AlbumId = 1,
                    Name = "Example Album",
                    Year = 2020
                },
                new Album
                {
                    AlbumId = 2,
                    Name = "Example Album 2",
                    Year = 2021
                }
           );
        }
    }
}
