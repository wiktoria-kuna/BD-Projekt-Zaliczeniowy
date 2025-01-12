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
        public DbSet<BookEntity> Books {get; set;}
        public DbSet<CategoryEntity> Categories {get; set;}
    }
}
