using System.ComponentModel.DataAnnotations;

namespace Pokedex.api.Entities;

public class Pokemon
{
    [Key]
    public int Pn { get; set; }
    public required string Name { get; set; }
    public int ElementId { get; set; }
    public Element? Element { get; set; }
    public int ElementaId { get; set; }
    public Elementa? Elementa { get; set; }
    public string? Description { get; set; }
}