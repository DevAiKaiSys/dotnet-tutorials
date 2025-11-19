using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config =>
{
    config.DocumentName = "TodoAPI";
    config.Title = "TodoAPI v1";
    config.Version = "v1";
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(config =>
    {
        config.DocumentTitle = "TodoAPI";
        config.Path = "/swagger";
        config.DocumentPath = "/swagger/{documentName}/swagger.json";
        config.DocExpansion = "list";
    });
}

var todoItems = app.MapGroup("/todoitems");

todoItems.MapGet("/", TodosApi.GetAllTodos);
todoItems.MapGet("/complete", TodosApi.GetCompleteTodos);
todoItems.MapGet("/{id}", TodosApi.GetTodo);
todoItems.MapPost("/", TodosApi.CreateTodo);
todoItems.MapPut("/{id}", TodosApi.UpdateTodo);
todoItems.MapDelete("/{id}", TodosApi.DeleteTodo);

app.Run();