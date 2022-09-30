using BlazorStudy.Models.Buffets;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorStudy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Broth>? Broths { get; set; }
        public DbSet<Noodle>? Noodles { get; set; }
        public DbSet<Garnish>? Garnishes { get; set; }
    }
}