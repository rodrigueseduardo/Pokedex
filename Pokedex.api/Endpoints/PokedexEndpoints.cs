using Microsoft.EntityFrameworkCore;
using Pokedex.api.Data;
using Pokedex.api.Dtos;
using Pokedex.api.Entities;
using Pokedex.api.Mapping;

namespace Pokedex.api.Endpoints;

public static class PokedexEndpoints
{

    const string GetPokedexEndpointsName = "GetPokedex";
    public static RouteGroupBuilder MapPokedexEndpoints(this WebApplication app)
    {

        var group = app.MapGroup("pokemons")
                       .WithParameterValidation();
        //lista toda a Pokédex
        group.MapGet("/", async (PokedexContext dbContext) =>
            await dbContext.Pokedex
                      .Include(pokemon => pokemon.Element)
                      .Select(pokemon => pokemon.ToPokedexSummaryDto())
                      .AsNoTracking()
                      .ToListAsync());

        //lista os pokémons por número da pokédex
        group.MapGet("/{pn}", async (int pn, PokedexContext dbContext) =>
        {
            Pokemon? pokemon = await dbContext.Pokedex.FindAsync(pn);

            return pokemon is null ?
                Results.NotFound() : Results.Ok(pokemon.ToPokedexDetailsDto());
        })
        .WithName(GetPokedexEndpointsName);

        return group;
    }
}
