using HelpApp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpApp.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync (Category category);
        Task UpdateCategoryAsync (Category category);
        Task RemoveCategoryAsync (int id);

    }
}
