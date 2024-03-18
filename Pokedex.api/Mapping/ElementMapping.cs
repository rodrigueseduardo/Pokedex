using Pokedex.api.Dtos;
using Pokedex.api.Entities;

namespace Pokedex.api.Mapping;

public static class ElementMapping
{
    public static ElementDto ToDto(this Element element)
    {
        return new ElementDto(element.Id, element.Name);
    }
}