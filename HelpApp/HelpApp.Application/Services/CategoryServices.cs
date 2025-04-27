using HelpApp.Application.Interfaces;
using HelpApp.Domain.Entities;
using HelpApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpApp.Application.Services
{
    public class CategoryServices : ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;

        public CategoryServices(ICategoryRepository categoryRepository) 
        { 
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _categoryRepository.GetCategories();
        }
        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _categoryRepository.GetById(id);
        }
        public async Task CreateCategoryAsync(Category category)
        {
            await _categoryRepository.Create(category);
        }
        public async Task UpdateCategoryAsync(Category category)
        {
            await _categoryRepository.Update(category);
        }
        public async Task RemoveCategoryAsync(int id)
        {
            var categoryToRemove = await _categoryRepository.GetById(id);
            if (categoryToRemove != null)
            {
                await _categoryRepository.Remove(categoryToRemove);
            }
        }
    }
}
