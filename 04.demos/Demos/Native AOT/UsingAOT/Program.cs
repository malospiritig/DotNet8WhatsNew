using System.Text.Json.Serialization;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

var todos = new Todo[] {
    new(1, "Learn C#"),
    new(2, "Watch a Pluralsight course on C#", DateOnly.FromDateTime(DateTime.Now)),
    new(3, "Walk the dog", DateOnly.FromDateTime(DateTime.Now.AddHours(1))),
    new(4, "Cook dinner"),
    new(5, "Buy gifts for Christmas", DateOnly.FromDateTime(DateTime.Now.AddDays(3)))
};

var todosApi = app.MapGroup("/todos");
todosApi.MapGet("/", () => todos);
todosApi.MapGet("/{id}", (int id) =>
    todos.FirstOrDefault(a => a.Id == id) is { } todo
        ? Results.Ok(todo)
        : Results.NotFound());

app.Run();

public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

[JsonSerializable(typeof(Todo[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

}
