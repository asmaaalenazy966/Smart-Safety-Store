using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var products = new List<object>{
    new { id=1, name="Small Box A", price=10.0 },
    new { id=2, name="Small Box B", price=8.0 }
};

app.MapGet("/", () => Results.Json(new { message = "SmartSafetyStore API running" }));
app.MapGet("/api/products", () => Results.Json(products));
app.MapPost("/api/alerts/sensor", async (HttpRequest req) =>
{
    var doc = await JsonDocument.ParseAsync(req.Body);
    return Results.Json(new { ok = true, received = doc.RootElement.ToString() });
});
app.MapPost("/api/cart/add", async (HttpRequest req) =>
{
    var doc = await JsonDocument.ParseAsync(req.Body);
    return Results.Json(new { ok = true, detail = "Item added to cart (demo)" });
});
app.Run();
