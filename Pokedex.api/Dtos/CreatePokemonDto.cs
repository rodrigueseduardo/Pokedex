using System.ComponentModel.DataAnnotations;

namespace Pokedex.api.Dtos;

public record class CreatePokemonDto(
    [Range(1, 3000)] int Pn,
    [Required][StringLength(20)]string Name,
    int ElementId,
    [Required] string Description
    );