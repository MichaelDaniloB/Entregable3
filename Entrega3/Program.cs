using System.Text.Json;
using Entrega3.Handler;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<LibroDTO> librosBD = new List<LibroDTO>();
LibroHandler libroHandler = new LibroHandler(librosBD);

List<AutorDTO> autoresBD = new List<AutorDTO>();
AutorHandler autorHandler = new AutorHandler(autoresBD);

app.MapPost("/api/v1/Libro", (LibroDTO libro) =>
{
    libroHandler.create(libro);
});

app.MapPut("/api/v1/libro/{id:guid}", (Guid id, LibroDTO libro) =>{
    libroHandler.update(libro, id);
});

app.MapDelete("/api/v1/libro/{id:guid}", (Guid id) =>
{
    libroHandler.eliminar(id);
    return Results.NoContent();
});

app.MapGet("/api/v1/libro", () =>
{
    return Results.Ok(libroHandler.All());
});

app.MapPost("/api/v1/Autor", (AutorDTO autor) =>
{
    autorHandler.create(autor);
});

app.MapPut("/api/v1/autor/{id:guid}", (Guid id, AutorDTO autor) =>
{
    autorHandler.update(autor, id);
});

app.MapDelete("/api/v1/autor/{id:guid}", (Guid id) =>
{
    autorHandler.eliminar(id);
    return Results.NoContent();
});

app.MapGet("/api/v1/autor", () =>
{
    return Results.Ok(autorHandler.All());
});

app.Run();
