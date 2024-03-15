using Pokedex.api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPokedexEndpoints();

app.Run();
