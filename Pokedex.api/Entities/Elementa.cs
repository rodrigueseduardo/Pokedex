using System.ComponentModel.DataAnnotations;

namespace Pokedex.api.Entities;
public class Elementa
{
    public int Id { get; set; }

    public required string Name { get; set; }
}