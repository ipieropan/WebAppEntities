using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages1 { get; set; }
        public DbSet<LanguagePerson> LanguagePeople { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>()
            .HasMany(c => c.People)
            .WithOne(e => e.City);

            modelBuilder.Entity<Country>()
            .HasMany(c => c.Cities)
            .WithOne(e => e.Country);

            modelBuilder.Entity<LanguagePerson>()
            .HasKey(sc => new { sc.LanguageName, sc.PersonId });


            modelBuilder.Entity<LanguagePerson>()
                .HasOne<Language>(sc => sc.Language)
                .WithMany(s => s.LanguagePerson)
                .HasForeignKey(sc => sc.LanguageName);




            modelBuilder.Entity<LanguagePerson>()
                .HasOne<Person>(sc => sc.Person)
                .WithMany(s => s.LanguagePerson)
                .HasForeignKey(sc => sc.PersonId);

        }


        
    }
}
