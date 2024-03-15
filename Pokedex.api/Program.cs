using Pokedex.api.Data;
using Pokedex.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = "DataSource = Pokedex.db";
builder.Services.AddSqlite <PokedexContext> (connString);

var app = builder.Build();

app.MapPokedexEndpoints();

app.Run();
