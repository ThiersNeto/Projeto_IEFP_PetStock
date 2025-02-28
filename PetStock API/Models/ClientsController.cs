using Microsoft.AspNetCore.Mvc;
using PetStockBlazor.Models;
using PetStockBlazor.Services;

namespace PetStockAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly FakeDataService _dataService;

        public ClientsController(FakeDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: api/clients
        [HttpGet]
        public ActionResult<IEnumerable<Client>> GetClients()
        {
            return _dataService.GetClients();
        }

        // GET: api/clients/{id}
        [HttpGet("{id}")]
        public ActionResult<Client> GetClient(int id)
        {
            var client = _dataService.GetClients().FirstOrDefault(c => c.Id == id);
            if (client == null)
                return NotFound();
            return client;
        }

        // POST: api/clients
        [HttpPost]
        public ActionResult<Client> AddClient([FromBody] Client client)
        {
            // Simula auto-incremento do Id
            var clients = _dataService.GetClients();
            client.Id = clients.Any() ? clients.Max(c => c.Id) + 1 : 1;
            clients.Add(client);
            return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client);
        }

        // PUT: api/clients/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateClient(int id, [FromBody] Client updatedClient)
        {
            var clients = _dataService.GetClients();
            var client = clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
                return NotFound();

            client.Name = updatedClient.Name;
            client.Email = updatedClient.Email;
            client.Phone = updatedClient.Phone;
            client.Address = updatedClient.Address;
            return NoContent();
        }

        // DELETE: api/clients/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteClient(int id)
        {
            var clients = _dataService.GetClients();
            var client = clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
                return NotFound();

            clients.Remove(client);
            return NoContent();
        }
    }
}
