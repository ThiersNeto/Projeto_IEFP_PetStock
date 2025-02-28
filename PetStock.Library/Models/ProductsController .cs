using Microsoft.AspNetCore.Mvc;
using PetStockBlazor.Models;
using PetStockBlazor.Services;

namespace PetStockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly FakeDataService _dataService;

        public ProductsController(FakeDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _dataService.GetProducts();
        }

        // GET: api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _dataService.GetProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return product;
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<Product> AddProduct([FromBody] Product product)
        {
            _dataService.AddProduct(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            var product = _dataService.GetProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            // Atualiza as propriedades do produto
            product.Name = updatedProduct.Name;
            product.Description = updatedProduct.Description;
            product.Price = updatedProduct.Price;
            product.StockQuantity = updatedProduct.StockQuantity;
            product.CategoryId = updatedProduct.CategoryId;
            product.ImageUrl = updatedProduct.ImageUrl;
            return NoContent();
        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _dataService.SoftDeleteProduct(id);
            return NoContent();
        }

        // GET: api/products/{id}/stockmovements
        [HttpGet("{id}/stockmovements")]
        public ActionResult<IEnumerable<StockMovement>> GetStockMovements(int id)
        {
            var product = _dataService.GetProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            var movements = _dataService.GetStockMovementsForProduct(id);
            return movements;
        }

        // POST: api/products/{id}/stockmovements
        [HttpPost("{id}/stockmovements")]
        public IActionResult RegisterStockMovement(int id, [FromBody] StockMovement movement)
        {
            var product = _dataService.GetProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            movement.ProductId = id;
            try
            {
                _dataService.RegisterStockMovement(movement);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(movement);
        }
    }
}
