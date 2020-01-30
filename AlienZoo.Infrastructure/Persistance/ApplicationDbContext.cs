using AlienZooDomain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlienZoo.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Alien> Alien { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // ConfigurePersons(modelBuilder);
            ConfigureAliens(modelBuilder);
            SeedDatabase(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }

        private void ConfigureAliens(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alien>()
                .HasOne(b => b.Handler)
                .WithMany(a => a.HandledAliens)
                .HasForeignKey(b => b.HandlerID);
        }

        private void ConfigurePersons(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().Property(x => x.Name);

        }
    }
}
