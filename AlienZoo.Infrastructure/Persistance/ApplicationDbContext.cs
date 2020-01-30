using AlienZoo.Application.Interfaces;
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
               /* new Predator { Id = 1, Name = "Predator", Age = 18, HandlerID = 1  },
                new Xenomorph { Id = 2, Name = "Mother", Age = 1, HandlerID = 1},
                new Wookiee { Id = 3, Name = "Tuggmacka", Age = 250, HandlerID = 2} */
                new Alien { Id = 1, Name = "Test", Age = 18, HandlerID = 1}
                );
        }

        private void ConfigureAliens(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Alien>()
                .HasOne(b => b.Handler);
               /* .WithMany(a => a.HandledAliens)
                .HasForeignKey(b => b.HandlerID);*/
        }

       /* private void ConfigurePredator(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Predator>().HasBaseType<Alien>()
                .HasOne(b => b.Handler)
                .WithMany(a => a.HandledAliens)
                .HasForeignKey(b => b.HandlerID);
        }

        private void ConfigureXenomorph(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Xenomorph>().HasBaseType<Alien>()
                .HasOne(b => b.Handler)
                .WithMany(a => a.HandledAliens)
                .HasForeignKey(b => b.HandlerID);
        }

        private void ConfigureWookiee(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wookiee>().HasBaseType<Alien>()
                .HasOne(b => b.Handler)
                .WithMany(a => a.HandledAliens)
                .HasForeignKey(b => b.HandlerID);
        } */

        private void ConfigurePersons(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Person>().Property(x => x.Name);

        }
    }
}
