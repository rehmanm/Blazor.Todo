using Blazor.Todo.Shared.Entities;

namespace Blazor.Todo.Shared.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await Task.Run(() =>
            {
                return new List<Category>
                {
                    new Category{
                        CategoryId = 1,
                        CategoryName = "Health",
                    },
                    new Category{
                        CategoryId = 2,
                        CategoryName = "Sports",
                    },
                };
            });
        }
    }
}
