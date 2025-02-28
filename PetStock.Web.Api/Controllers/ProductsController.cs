using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStockAPI.Data;
using PetStockAPI.Models;

namespace PetStockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly PetStockDbContext _context;

        public ProductsController(PetStockDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products
                .Include(p => p.Category)
                .Where(p => !p.IsDeleted)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.StockMovements)
                .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);
            if (product == null)
                return NotFound();
            return product;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest();

            _context.Entry(product).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(e => e.Id == id))
                    return NotFound();
                throw;
            }
            return NoContent();
        }

        // Soft delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();

            product.IsDeleted = true;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // Registrar movimentação de estoque
        [HttpPost("{id}/stockmovements")]
        public async Task<IActionResult> RegisterStockMovement(int id, [FromBody] StockMovement movement)
        {
            var product = await _context.Products
                .Include(p => p.StockMovements)
                .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);
            if (product == null)
                return NotFound();

            movement.ProductId = id;
            product.StockMovements.Add(movement);

            if (movement.Type == "Entrada")
            {
                product.StockQuantity += movement.Quantity;
            }
            else if (movement.Type == "Saída")
            {
                if (product.StockQuantity >= movement.Quantity)
                    product.StockQuantity -= movement.Quantity;
                else
                    return BadRequest("Estoque insuficiente para realizar a saída.");
            }
            else
            {
                return BadRequest("Tipo de movimentação inválido.");
            }

            _context.StockMovements.Add(movement);
            await _context.SaveChangesAsync();
            return Ok(movement);
        }
    }
}
