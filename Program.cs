using Services;
using Settings;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<TodoDbSettings>(builder.Configuration.GetSection("TodoDB"));
builder.Services.AddSingleton<ITodoItemService, TodoItemService>();


var app = builder.Build();

app.MapGet("/todo-items", () => {});
app.MapGet("/todo-items/{id}", (string id) => {
    var todoItem = new {
        Id =  Guid.NewGuid().ToString(),
        Title ="Complete Todo in Csharp",
        IsCompleted = false
    };
    return Results.Ok(todoItem);
});
app.MapPost("/todo-items", () => {});
app.MapPut("/todo-items/{id}", (string id) => {});
app.MapDelete("/todo-items/{id}", () => {});

app.Run();
