using Pokedex.api.Data;
using Pokedex.api.Dtos;
using Pokedex.api.Entities;
using Pokedex.api.Mapping;

namespace Pokedex.api.Endpoints;

public static class PokedexEndpoints
{
    private static readonly List<PokedexSummaryDto> pokedex = [
    new(
        150,
        "Mewtwo",
        "Psychic",
        "Generic Description"
        ),
    new(
        151,
        "Mew",
        "Psychic",
        "Generic Description"
        )
    ];

    public static RouteGroupBuilder MapPokedexEndpoints(this WebApplication app)
    {

        var group = app.MapGroup("pokemons")
                       .WithParameterValidation();
        //lista toda a Pokédex
        group.MapGet("/", () => pokedex);

        //lista os pokémons por número da pokédex
        group.MapGet("/{pn}", (int pn, PokedexContext dbContext) =>
        {
            Pokemon? pokemon = dbContext.Pokedex.Find(pn);

            return pokemon is null ?
                Results.NotFound() : Results.Ok(pokemon.ToPokedexDetailsDto());
        });

        return group;
    }
}
