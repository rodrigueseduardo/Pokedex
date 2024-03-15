﻿using Pokedex.api.Dtos;

namespace Pokedex.api.Endpoints;

public static class PokedexEndpoints
{
    private static readonly List<PokedexDto> pokedex = [
    new(
        150,
        "Mewtwo",
        "Psiquico",
        "Mewtwo é um Pokémon que foi criado por manipulação genética. No entanto, embora o poder científico dos humanos tenha criado o corpo desse Pokémon, eles não conseguiram dotar Mewtwo de um coração compassivo. Como suas habilidades de batalha foram elevadas ao nível máximo, ele pensa apenas em derrotar seus inimigos, independente de quem seja."
        ),
    new(
        151,
        "Mew",
        "Psiquico",
        "Diz-se que Mew possui a composição genética de todos os Pokémon. Ele é capaz de se tornar invisível à vontade, por isso evita a percepção, mesmo que se aproxime das pessoas. Quando é visto detalhadamente através de um microscópio, os cabelos curtos, finos e delicados deste Pokémon mítico podem ser vistos."
        )
    ];

    public static WebApplication MapPokedexEndpoints(this WebApplication app)
    {
        //lista toda a Pokédex
        app.MapGet("pokemons", () => pokedex);

        //lista os pokémons por número da pokédex
        app.MapGet("pokemons/{pn}", (int pn) =>
        {
            PokedexDto? pokemon = pokedex.Find(pokemon => pokemon.Pn == pn);

            return pokemon is null ? Results.NotFound() : Results.Ok(pokemon);
        });

        return app;
    }
}