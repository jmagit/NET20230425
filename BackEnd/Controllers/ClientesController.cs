using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Controllers {
    public class ClienteShortDTO {
        /// <summary>
        /// Identificador del cliente
        /// </summary>
        public int Id { get; init; }
        public string RazonSocial { get; init; }

        public ClienteShortDTO(int id, string razonSocial) {
            Id = id;
            RazonSocial = razonSocial;
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase {
        private readonly AWContext _context;

        public ClientesController(AWContext context) {
            _context = context;
        }

        /// <summary>
        /// Devuelve la lista de clientes ....
        /// </summary>
        /// <param name="page">Primera página es la 0</param>
        /// <param name="rows"></param>
        /// <returns></returns>
        // GET: api/Clientes?page=1&rows=10
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteShortDTO>>> GetCustomers(int page=0, int rows=20) {
            if(_context.Customers == null) {
                return NotFound();
            }
            return await _context.Customers
                .Skip(page * rows).Take(rows)
                .Select(f => new ClienteShortDTO(f.CustomerId, f.CompanyName))
                .ToListAsync();
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id) {
            if(_context.Customers == null) {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);

            if(customer == null) {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Clientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer) {
            if(id != customer.CustomerId) {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException) {
                if(!CustomerExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Clientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer) {
            if(_context.Customers == null) {
                return Problem("Entity set 'AWContext.Customers'  is null.");
            }
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id) {
            if(_context.Customers == null) {
                return NotFound();
            }
            var customer = await _context.Customers.FindAsync(id);
            if(customer == null) {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id) {
            return (_context.Customers?.Any(e => e.CustomerId == id)).GetValueOrDefault();
        }
    }
}
