namespace Pokedex.api.Dtos;

public record class PokedexDetailsDto
(
    int Pn,
    string Name,
    int ElementId,
    string Description
);