using System.ComponentModel.DataAnnotations;

namespace Pokedex.api.Entities;
public class Element
{
    public int Id { get; set; }

    public required string Name { get; set; }
}