using Microsoft.EntityFrameworkCore;
using Pokedex.api.Entities;

namespace Pokedex.api.Data;

public class PokedexContext(DbContextOptions<PokedexContext> options) : DbContext(options)
{
    public DbSet<Pokemon> Pokemons => Set<Pokemon>();

    public DbSet<Element> Elements => Set<Element>();

    public DbSet<Elementa> Elementsa => Set<Elementa>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Element>().HasData
        (
            new { Id = 99, Name = "None"},
            new { Id = 1, Name = "Normal" },
            new { Id = 2, Name = "Fire" },
            new { Id = 3, Name = "Water" },
            new { Id = 4, Name = "Electric" },
            new { Id = 5, Name = "Grass" },
            new { Id = 6, Name = "Ice" },
            new { Id = 7, Name = "Fighting" },
            new { Id = 8, Name = "Poison" },
            new { Id = 9, Name = "Ground" },
            new { Id = 10, Name = "Flying" },
            new { Id = 11, Name = "Psychic" },
            new { Id = 12, Name = "Bug" },
            new { Id = 13, Name = "Rock" },
            new { Id = 14, Name = "Ghost" },
            new { Id = 15, Name = "Dragon" },
            new { Id = 16, Name = "Dark" },
            new { Id = 17, Name = "Steel" },
            new { Id = 18, Name = "Fairy" },
            new { Id = 19, Name = "Shadow" },
            new { Id = 20, Name = "???" },
            new { Id = 21, Name = "Stellar" }
        );

                modelBuilder.Entity<Elementa>().HasData
        (
            new { Id = 99, Name = "None"},
            new { Id = 1, Name = "Normal" },
            new { Id = 2, Name = "Fire" },
            new { Id = 3, Name = "Water" },
            new { Id = 4, Name = "Electric" },
            new { Id = 5, Name = "Grass" },
            new { Id = 6, Name = "Ice" },
            new { Id = 7, Name = "Fighting" },
            new { Id = 8, Name = "Poison" },
            new { Id = 9, Name = "Ground" },
            new { Id = 10, Name = "Flying" },
            new { Id = 11, Name = "Psychic" },
            new { Id = 12, Name = "Bug" },
            new { Id = 13, Name = "Rock" },
            new { Id = 14, Name = "Ghost" },
            new { Id = 15, Name = "Dragon" },
            new { Id = 16, Name = "Dark" },
            new { Id = 17, Name = "Steel" },
            new { Id = 18, Name = "Fairy" },
            new { Id = 19, Name = "Shadow" },
            new { Id = 20, Name = "???" },
            new { Id = 21, Name = "Stellar" }
        );
    }
}