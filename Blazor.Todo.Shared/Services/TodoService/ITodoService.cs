using Blazor.Todo.Shared.Entities;

namespace Blazor.Todo.Shared.Services.TodoService
{
    public interface ITodoService
    {
        Task<List<Todos>> GetTodosAsync();
        Task<List<Todos>> GetTodosByCategoryAsync(string categoryName);

        Task<Todos> UpdateTodo(int id, Todos updatedTodos);
    }
}
