using AlienZooDomain;
using AlienZooDomain.Aliens;
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
            ConfigurePersons(modelBuilder);
            ConfigureAliens(modelBuilder);
            SeedDatabase(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }

        private void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData (
                new Person { Id = 1, Name = "Daniel" },
                new Person { Id = 2, Name = "Mike" }
                );

            modelBuilder.Entity<Alien>().HasData(
                new Alien { Id = 1, Name = "Predator", Age = 18, HandlerID = 1, AlienType = "Predator" },
                new Alien { Id = 2, Name = "Mother", Age = 1, HandlerID = 1, AlienType = "Xenomorph" },
                new Alien { Id = 3, Name = "Tuggmacka", Age = 250, HandlerID = 2, AlienType = "Wookiee" }
                );
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
