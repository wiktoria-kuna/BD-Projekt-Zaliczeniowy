using Biblioteka.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<MemberEntity> Members {get; set;}
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<BookEntity> Books {get; set;}
        public DbSet<CategoryEntity> Categories {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed dla kategorii
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { Id = 1, Name = "Horror", Description = "Książki o przerażających historiach, duchach i nadprzyrodzonych wydarzeniach." },
                new CategoryEntity { Id = 2, Name = "Fantastyka", Description= "Literatura pełna magii, mitologii i wyimaginowanych światów."},
                new CategoryEntity { Id = 3, Name = "Kryminał", Description= "Historie o detektywach, tajemnicach i zagadkach kryminalnych."},
                new CategoryEntity { Id = 4, Name = "Romans", Description = "Opowieści o miłości, relacjach i emocjach." },
                new CategoryEntity { Id = 5, Name = "Science Fiction", Description = "Książki o przyszłości, technologii i kosmosie." },
                new CategoryEntity { Id = 6, Name = "Biografia", Description = "Życiorysy znanych osób, opowiadające o ich życiu i osiągnięciach." },
                new CategoryEntity { Id = 7, Name = "Historyczna", Description = "Powieści osadzone w przeszłości, często z elementami historycznymi." },
                new CategoryEntity { Id = 8, Name = "Przygodowa", Description = "Książki pełne akcji, odkryć i ekscytujących podróży." },
                new CategoryEntity { Id = 9, Name = "Thriller", Description = "Historie pełne napięcia, z zaskakującymi zwrotami akcji." }
             );
            //seed dla książek
            modelBuilder.Entity<BookEntity>().HasData(
                new BookEntity { Id = 1, Title = "Lśnienie", Description = "Akcja powieści rozgrywa się w hotelu Panorama (ang. The Overlook), położonym wysoko w górach, gdzie Jack Torrance z żoną i małym synkiem ma zostać na zimę, by go doglądać. Jack ma duże problemy ze sobą i swoją twórczością (jest pisarzem), a jego syn Danny ma zdolności parapsychiczne (zdolność lśnienia), dzięki którym widzi wiele makabrycznych scen, odgrywających się przed laty w opuszczonym hotelu. Obaj wraz z ojcem wyczuwają, że w Panoramie nie są sami.", Author = "Stephen King", CategoryId = 1 });
        }       
    }
}
