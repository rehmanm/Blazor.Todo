using Blazor.Todo.Shared.Entities;

namespace Blazor.Todo.Shared.Services.TodoService
{
    public class TodoService : ITodoService
    {
        private readonly List<Todos> _todoList = new List<Todos>();
        public TodoService()
        {
            _todoList.Add(new Todos {Id=1, Title = "First", DueDate = DateTime.Now.AddDays(7), CategoryName = "Sports" });
            _todoList.Add(new Todos {Id=2, Title = "Second", DueDate = DateTime.Now.AddDays(7), IsComplete = true, CategoryName = "Health" });
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

        public async Task<Todos> UpdateTodo(int id, Todos updatedTodos)
        {
            var index = _todoList.FindIndex(todo => todo.Id == id);

            if (index != -1)
            {
                _todoList[index] = updatedTodos;
            }

            return await Task.FromResult(updatedTodos); 
        }
    }
}
