namespace Pokedex.api.Dtos;

public record class PokedexDto
(
    int Pn,
    string Nome,
    string Tipo,
    string Descricao
);