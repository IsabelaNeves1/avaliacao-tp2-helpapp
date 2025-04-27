using Microsoft.AspNetCore.Mvc;
using HelpApp.Application.Interfaces;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using HelpApp.Domain.Entities;

namespace HelpApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _categoryService.CreateCategoryAsync(category);
            return CreatedAtAction(nameof(Get), new {id = category.Id}, category);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Category category)
        {
            if (id != category.Id)
            {
                return BadRequest("O ID da rota não corresponde ao ID do Objeto.");
            }
            if (!ModelState.IsValid)
            { 
            return BadRequest(ModelState);
            }
            await _categoryService.UpdateCategoryAsync(category);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var categoryToDelete = await _categoryService.GetCategoryByIdAsync(id);
            if (categoryToDelete==null)
            {
                return NotFound();
            }
            await _categoryService.RemoveCategoryAsync(id);
            return NoContent();
        }
    }
}
