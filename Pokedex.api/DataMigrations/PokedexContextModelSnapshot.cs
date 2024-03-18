﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokedex.api.Data;

#nullable disable

namespace Pokedex.api.DataMigrations
{
    [DbContext(typeof(PokedexContext))]
    partial class PokedexContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Pokedex.api.Entities.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Elements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Normal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fire"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Water"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Electric"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Grass"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ice"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Fighting"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Poison"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ground"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Flying"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Psychic"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Bug"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Ghost"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Dragon"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Dark"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Steel"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Fairy"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Shadow"
                        },
                        new
                        {
                            Id = 20,
                            Name = "???"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Stellar"
                        });
                });

            modelBuilder.Entity("Pokedex.api.Entities.Pokemon", b =>
                {
                    b.Property<int>("Pn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("ElementId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Pn");

                    b.HasIndex("ElementId");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("Pokedex.api.Entities.Pokemon", b =>
                {
                    b.HasOne("Pokedex.api.Entities.Element", "Element")
                        .WithMany()
                        .HasForeignKey("ElementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");
                });
#pragma warning restore 612, 618
        }
    }
}
