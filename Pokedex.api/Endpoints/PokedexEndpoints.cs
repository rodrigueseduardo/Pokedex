using Pokedex.api.Dtos;

namespace Pokedex.api.Endpoints;

public static class PokedexEndpoints
{
    private static readonly List<PokedexDto> pokedex = [
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
        group.MapGet("/{pn}", (int pn) =>
        {
            PokedexDto? pokemon = pokedex.Find(pokemon => pokemon.Pn == pn);

            return pokemon is null ? Results.NotFound() : Results.Ok(pokemon);
        });

        return group;
    }
}
