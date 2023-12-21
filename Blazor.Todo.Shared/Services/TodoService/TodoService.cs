using Blazor.Todo.Shared.Entities;

namespace Blazor.Todo.Shared.Services.TodoService
{
    public class TodoService : ITodoService
    {
        private readonly List<Todos> _todoList = new List<Todos>();
        public TodoService()
        {
            _todoList.Add(new Todos { Title = "First", DueDate = DateTime.Now.AddDays(7), CategoryName = "Sports" });
            _todoList.Add(new Todos { Title = "Second", DueDate = DateTime.Now.AddDays(7), IsComplete = true, CategoryName = "Health" });
        }
        public async Task<List<Todos>> GetTodosAsync()
        {
            return await Task.Run(() => _todoList);
        }

        public async Task<List<Todos>> GetTodosByCategoryAsync(string categoryName)
        {
            return await Task.Run(() =>
            {
                var items = _todoList.Where(todo => todo.CategoryName.ToLower() == categoryName.ToLower()).ToList();
                return items;
            });
        }
    }
}
