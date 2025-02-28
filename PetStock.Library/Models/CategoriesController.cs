using Microsoft.AspNetCore.Mvc;
using PetStockBlazor.Models;
using PetStockBlazor.Services;

namespace PetStockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly FakeDataService _dataService;

        public CategoriesController(FakeDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/categories
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return _dataService.GetCategories();
        }

        // GET: api/categories/{id}
        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            var category = _dataService.GetCategories().FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return category;
        }

        // POST: api/categories
        [HttpPost]
        public ActionResult<Category> AddCategory([FromBody] Category category)
        {
            // Simula auto-incremento do Id
            var categories = _dataService.GetCategories();
            category.Id = categories.Any() ? categories.Max(c => c.Id) + 1 : 1;
            categories.Add(category);
            return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
        }

        // PUT: api/categories/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] Category updatedCategory)
        {
            var categories = _dataService.GetCategories();
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();

            category.Name = updatedCategory.Name;
            category.IsDeleted = updatedCategory.IsDeleted;
            return NoContent();
        }

        // DELETE: api/categories/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _dataService.SoftDeleteCategory(id);
            return NoContent();
        }
    }
}
