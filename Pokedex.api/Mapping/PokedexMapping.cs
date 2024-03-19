using Pokedex.api.Entities;
using Pokedex.api.Dtos;

namespace Pokedex.api.Mapping;

public static class PokedexMapping
{
    public static Pokemon ToEntity(this CreatePokemonDto pokemon)
    {
        return new Pokemon()
        {
            Pn = pokemon.Pn,
            Name = pokemon.Name,
            ElementId = pokemon.ElementId,
            ElementaId = pokemon.ElementaId,
            Description = pokemon.Description
        };
    }

    public static Pokemon ToEntity(this UpdatePokemonDto pokemon, int id)
    {
        return new Pokemon()
        {
            Pn = pokemon.Pn,
            Name = pokemon.Name,
            ElementId = pokemon.ElementId,
            ElementaId = pokemon.ElementaId,
            Description = pokemon.Description
        };
    }

    public static PokedexSummaryDto ToPokedexSummaryDto(this Pokemon pokemon)
    {
        return new(
            pokemon.Pn,
            pokemon.Name,
            pokemon.Element!.Name,
            pokemon.Elementa!.Name,
            pokemon.Description!
        );
    }

    public static PokedexDetailsDto ToPokedexDetailsDto(this Pokemon pokemon)
    {
        return new(
            pokemon.Pn,
            pokemon.Name,
            pokemon.ElementId,
            pokemon.ElementaId,
            pokemon.Description!
        );
    }
}
