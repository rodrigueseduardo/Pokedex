namespace Pokedex.api.Dtos;

public record class PokedexDto
(
    int Pn,
    string Nome,
    string Tipoa,
    string Tipob,
    string Descricao
);