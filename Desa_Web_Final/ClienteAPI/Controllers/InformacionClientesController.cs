using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClienteAPI.Data;
using ClienteAPI.Models;

namespace ClienteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformacionClientesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InformacionClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/InformacionClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InformacionCliente>>> GetInformacionClientes()
        {
            return await _context.InformacionClientes
                .OrderBy(ic => ic.FechaCreacion)  // Ordena por fecha de creación
                .ToListAsync();
        }

        // GET: api/InformacionClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InformacionCliente>> GetInformacionCliente(int id)
        {
            var informacionCliente = await _context.InformacionClientes.FindAsync(id);

            if (informacionCliente == null)
            {
                return NotFound();
            }

            return informacionCliente;
        }

        // POST: api/InformacionClientes
        [HttpPost]
        public async Task<ActionResult<InformacionCliente>> PostInformacionCliente(InformacionCliente informacionCliente)
        {
            _context.InformacionClientes.Add(informacionCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInformacionCliente", new { id = informacionCliente.ID }, informacionCliente);
        }

        // PUT: api/InformacionClientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInformacionCliente(int id, InformacionCliente informacionCliente)
        {
            if (id != informacionCliente.ID)
            {
                return BadRequest();
            }

            _context.Entry(informacionCliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/InformacionClientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInformacionCliente(int id)
        {
            var informacionCliente = await _context.InformacionClientes.FindAsync(id);
            if (informacionCliente == null)
            {
                return NotFound();
            }

            _context.InformacionClientes.Remove(informacionCliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
