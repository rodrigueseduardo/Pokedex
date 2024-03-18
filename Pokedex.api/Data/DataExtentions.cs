using Microsoft.EntityFrameworkCore;

namespace Pokedex.api.Data;

public static class DataExtentions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<PokedexContext>();
        await dbContext.Database.MigrateAsync();
    }
}