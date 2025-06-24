using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using productosAPI.Models;
using productosAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=localhost, 1433;Database=ProductosDB;User Id=sa;Password=P@55w0rd!;TrustServerCertificate=True;"));

var app = builder.Build();

app.MapGet("/productos", async (AppDbContext db) =>
    await db.Productos.ToListAsync());

app.MapGet("/productos/{id}", async (int id, AppDbContext db) =>
     await db.Productos.FindAsync(id) is Producto producto
        ? Results.Ok(producto)
        : Results.NotFound());

app.MapPost("/productos", async (Producto producto, AppDbContext db) =>
{
    db.Productos.Add(producto);
    await db.SaveChangesAsync();
    return Results.Created($"/productos/{producto.Id}", producto);
}
);

app.MapPut("/productos/{id}", async (int id, Producto nuevoProducto, AppDbContext db) =>
{
    var productoExistente = await db.Productos.FindAsync(id);

    if (productoExistente is null)
        return Results.NotFound();

    productoExistente.Nombre = nuevoProducto.Nombre;
    productoExistente.Descripcion = nuevoProducto.Descripcion;
    productoExistente.Precio = nuevoProducto.Precio;
    productoExistente.Stock = nuevoProducto.Stock;

    await db.SaveChangesAsync();
    return Results.Ok(productoExistente);
});

app.MapDelete("/productos/{id}", async (int id, AppDbContext db) =>
{
    var producto = await db.Productos.FindAsync(id);

    if (producto is null)
        return Results.NotFound();
    db.Productos.Remove(producto);
    await db.SaveChangesAsync();
    return Results.Ok(producto);
});

app.Run();
