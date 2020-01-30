﻿// <auto-generated />
using AlienZoo.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlienZoo.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200130132107_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlienZooDomain.Alien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AlienType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HandlerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HandlerID");

                    b.ToTable("Alien");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 18,
                            AlienType = "Predator",
                            HandlerID = 1,
                            Name = "Predator"
                        },
                        new
                        {
                            Id = 2,
                            Age = 1,
                            AlienType = "Xenomorph",
                            HandlerID = 1,
                            Name = "Mother"
                        },
                        new
                        {
                            Id = 3,
                            Age = 250,
                            AlienType = "Wookiee",
                            HandlerID = 2,
                            Name = "Tuggmacka"
                        });
                });

            modelBuilder.Entity("AlienZooDomain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Daniel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mike"
                        });
                });

            modelBuilder.Entity("AlienZooDomain.Alien", b =>
                {
                    b.HasOne("AlienZooDomain.Person", "Handler")
                        .WithMany("HandledAliens")
                        .HasForeignKey("HandlerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
