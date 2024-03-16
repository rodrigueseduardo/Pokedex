using Microsoft.EntityFrameworkCore;

namespace Pokedex.api.Data;

public static class DataExtentions
{
    public static void MigrateDb(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<PokedexContext>();
        dbContext.Database.Migrate();
    }
}