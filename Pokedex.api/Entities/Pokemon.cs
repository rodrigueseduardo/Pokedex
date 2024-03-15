using System.ComponentModel.DataAnnotations;

namespace Pokedex.api.Entities;

public class Pokemon
{
    [Key]
    public int Pn { get; set; }
    public string? Nome { get; set; }
    public string? Tipoa { get; set; }
    public string? Tipob { get; set; }
    public string? Descricao { get; set; }
}
