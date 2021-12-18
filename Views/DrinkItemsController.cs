using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantMS.Data;
using RestaurantMS.Models;

namespace RestaurantMS.Views
{
    public class DrinkItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DrinkItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DrinkItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.DrinkItem.ToListAsync());
        }

        // GET: DrinkItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkItem = await _context.DrinkItem
                .FirstOrDefaultAsync(m => m.Drink_ID == id);
            if (drinkItem == null)
            {
                return NotFound();
            }

            return View(drinkItem);
        }

        // GET: DrinkItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DrinkItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Drink_ID,Drink_capacity,Item_ID")] DrinkItem drinkItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drinkItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(drinkItem);
        }

        // GET: DrinkItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkItem = await _context.DrinkItem.FindAsync(id);
            if (drinkItem == null)
            {
                return NotFound();
            }
            return View(drinkItem);
        }

        // POST: DrinkItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Drink_ID,Drink_capacity,Item_ID")] DrinkItem drinkItem)
        {
            if (id != drinkItem.Drink_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drinkItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DrinkItemExists(drinkItem.Drink_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(drinkItem);
        }

        // GET: DrinkItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var drinkItem = await _context.DrinkItem
                .FirstOrDefaultAsync(m => m.Drink_ID == id);
            if (drinkItem == null)
            {
                return NotFound();
            }

            return View(drinkItem);
        }

        // POST: DrinkItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var drinkItem = await _context.DrinkItem.FindAsync(id);
            _context.DrinkItem.Remove(drinkItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DrinkItemExists(int id)
        {
            return _context.DrinkItem.Any(e => e.Drink_ID == id);
        }
    }
}
