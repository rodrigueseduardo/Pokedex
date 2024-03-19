using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Pokedex.api.Data;
using Pokedex.api.Dtos;
using Pokedex.api.Entities;
using Pokedex.api.Mapping;

namespace Pokedex.api.Endpoints;

public static class PokedexEndpoints
{
    const string GetPokedexEndpointName = "GetPokedex";

    public static RouteGroupBuilder MapPokedexEndpoints(this WebApplication app)
    {

        var group = app.MapGroup("pokemons")
                       .WithParameterValidation();
        //GET /pokemons
        group.MapGet("/", async (PokedexContext dbContext) =>
            await dbContext.Pokemons
                      .Include(pokemon => pokemon.Element)
                      .Include(pokemon => pokemon.Elementa)
                      .Select(pokemon => pokemon.ToPokedexSummaryDto())
                      .AsNoTracking()
                      .ToListAsync());

        //GET /pokemons/1
        group.MapGet("/{pn}", async (int pn, PokedexContext dbContext) =>
        {
            Pokemon? pokemon = await dbContext.Pokemons.FindAsync(pn);

            return pokemon is null ?
                Results.NotFound() : Results.Ok(pokemon.ToPokedexDetailsDto());
        })
        .WithName(GetPokedexEndpointName);

        //POST /pokemons
        group.MapPost("/", async (CreatePokemonDto newPokemon, PokedexContext dbContext) =>
        {
            Pokemon pokemon = newPokemon.ToEntity();

            dbContext.Pokemons.Add(pokemon);
            await dbContext.SaveChangesAsync();

            return Results.CreatedAtRoute(GetPokedexEndpointName, new { pn = pokemon.Pn },
            pokemon.ToPokedexDetailsDto());
        });

        //PUT /games/1
        group.MapPut("/{pn}", async (int pn, UpdatePokemonDto updatedPokemon, PokedexContext dbContext) =>
        {
            var existingPokemon = await dbContext.Pokemons.FindAsync(pn);

            if (existingPokemon is null)
            {
                return Results.NotFound();
            }

            dbContext.Entry(existingPokemon)
                        .CurrentValues
                        .SetValues(updatedPokemon.ToEntity(pn));

            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        //DELETE /pokemons/1
        group.MapDelete("/{id}", async (int id, PokedexContext dbContext) =>
        {
            await dbContext.Pokemons
                    .Where(pokemon => pokemon.Pn == id)
                    .ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
    private static void WithParameterValidation()
    {
        throw new NotImplementedException();
    }
}
