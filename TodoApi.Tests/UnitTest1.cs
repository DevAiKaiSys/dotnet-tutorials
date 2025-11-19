using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace TodoApi.Tests;

public class UnitTest1
{
    private TodoDb CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<TodoDb>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
        return new TodoDb(options);
    }

    [Fact]
    public async Task GetAllTodos_ReturnsOkOfTodosResult()
    {
        // Arrange
        var db = CreateDbContext();

        // Act
        var result = await TodosApi.GetAllTodos(db);

        // Assert: Check for the correct returned type
        Assert.IsType<Ok<TodoItemDTO[]>>(result);
    }
}
