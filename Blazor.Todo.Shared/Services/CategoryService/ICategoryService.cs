using Blazor.Todo.Shared.Entities;

namespace Blazor.Todo.Shared.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
    }
}
