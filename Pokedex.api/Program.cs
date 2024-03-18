using Pokedex.api.Data;
using Pokedex.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("Pokedex");
builder.Services.AddSqlite<PokedexContext>(connString);

var app = builder.Build();

app.MapPokedexEndpoints();

app.MapElementsEndpoints();

await app.MigrateDbAsync();

app.Run();