using Microsoft.EntityFrameworkCore;
using Pokedex.api.Entities;

namespace Pokedex.api.Data;

public class PokedexContext(DbContextOptions<PokedexContext> options) : DbContext(options)
{
    public DbSet<Pokemon> Pokedex => Set<Pokemon>();

    public DbSet<Element> Elements => Set<Element>();
}