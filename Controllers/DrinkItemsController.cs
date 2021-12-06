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
    public class DrinkItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DrinkItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DrinkItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DrinkItem>>> GetDrinkItem()
        {
            return await _context.DrinkItem.ToListAsync();
        }

        // GET: api/DrinkItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DrinkItem>> GetDrinkItem(int id)
        {
            var drinkItem = await _context.DrinkItem.FindAsync(id);

            if (drinkItem == null)
            {
                return NotFound();
            }

            return drinkItem;
        }

        // PUT: api/DrinkItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrinkItem(int id, DrinkItem drinkItem)
        {
            if (id != drinkItem.Drink_ID)
            {
                return BadRequest();
            }

            _context.Entry(drinkItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrinkItemExists(id))
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

        // POST: api/DrinkItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DrinkItem>> PostDrinkItem(DrinkItem drinkItem)
        {
            _context.DrinkItem.Add(drinkItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDrinkItem", new { id = drinkItem.Drink_ID }, drinkItem);
        }

        // DELETE: api/DrinkItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrinkItem(int id)
        {
            var drinkItem = await _context.DrinkItem.FindAsync(id);
            if (drinkItem == null)
            {
                return NotFound();
            }

            _context.DrinkItem.Remove(drinkItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DrinkItemExists(int id)
        {
            return _context.DrinkItem.Any(e => e.Drink_ID == id);
        }
    }
}
