using Microsoft.EntityFrameworkCore;
using Pokedex.api.Data;
using Pokedex.api.Mapping;

namespace Pokedex.api.Endpoints;

public static class ElementsEndpoints
{
    public static RouteGroupBuilder MapElementsEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("elements");

        group.MapGet("/", async (PokedexContext dbContext) =>
            await dbContext.Elements
                            .Select(element => element.ToDto())
                            .AsNoTracking()
                            .ToListAsync());

        return group;
    }
}
