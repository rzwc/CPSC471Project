using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantMS.Data;
using RestaurantMS.Models;

namespace RestaurantMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryCarsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DeliveryCarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DeliveryCars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeliveryCar>>> GetDeliveryCar()
        {
            return await _context.DeliveryCar.ToListAsync();
        }

        // GET: api/DeliveryCars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryCar>> GetDeliveryCar(string id)
        {
            var deliveryCar = await _context.DeliveryCar.FindAsync(id);

            if (deliveryCar == null)
            {
                return NotFound();
            }

            return deliveryCar;
        }

        // PUT: api/DeliveryCars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliveryCar(string id, DeliveryCar deliveryCar)
        {
            if (id != deliveryCar.License_plate)
            {
                return BadRequest();
            }

            _context.Entry(deliveryCar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryCarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DeliveryCars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DeliveryCar>> PostDeliveryCar(DeliveryCar deliveryCar)
        {
            _context.DeliveryCar.Add(deliveryCar);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DeliveryCarExists(deliveryCar.License_plate))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetDeliveryCar), new { id = deliveryCar.License_plate }, deliveryCar);
        }

        // DELETE: api/DeliveryCars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeliveryCar(string id)
        {
            var deliveryCar = await _context.DeliveryCar.FindAsync(id);
            if (deliveryCar == null)
            {
                return NotFound();
            }

            _context.DeliveryCar.Remove(deliveryCar);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeliveryCarExists(string id)
        {
            return _context.DeliveryCar.Any(e => e.License_plate == id);
        }
    }
}
