using Microsoft.OpenApi.Models;
using PizzaStore.Db;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "PizzaStore API", Description= "Making the Pizza you love", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API v1");
    });
}

app.MapGet("/pizzas/{Id}" , (int Id) => PizzaDb.GetPizza(Id)); // Get a pizza by Id
app.MapGet("/pizzas", () => PizzaDb.GetPizzas()); // Get all pizzas
app.MapPost("/pizzas", (Pizza pizza) => PizzaDb.CreatePizza(pizza)); // Create a new pizza
app.MapPut("/pizzas", (Pizza pizza) => PizzaDb.UpdatePizza(pizza)); // Update an existing pizza
app.MapDelete("/pizzas/{Id}", (int Id) => PizzaDb.RemovePizza(Id)); // Delete a pizza by Id
app.MapGet("/", () => Results.Text("<h1 style='text-align:center;'>Welcome to the Pizza Store API!</h1>", "text/html")); // Welcome message

app.Run();
