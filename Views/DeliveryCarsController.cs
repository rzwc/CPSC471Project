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
    public class DeliveryCarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeliveryCarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryCars
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeliveryCar.ToListAsync());
        }

        // GET: DeliveryCars/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryCar = await _context.DeliveryCar
                .FirstOrDefaultAsync(m => m.License_plate == id);
            if (deliveryCar == null)
            {
                return NotFound();
            }

            return View(deliveryCar);
        }

        // GET: DeliveryCars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryCars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("License_plate,Mileage,Car_colour,Car_model,Is_active,Longitude,Latitude,Store_ID")] DeliveryCar deliveryCar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryCar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryCar);
        }

        // GET: DeliveryCars/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryCar = await _context.DeliveryCar.FindAsync(id);
            if (deliveryCar == null)
            {
                return NotFound();
            }
            return View(deliveryCar);
        }

        // POST: DeliveryCars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("License_plate,Mileage,Car_colour,Car_model,Is_active,Longitude,Latitude,Store_ID")] DeliveryCar deliveryCar)
        {
            if (id != deliveryCar.License_plate)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryCar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryCarExists(deliveryCar.License_plate))
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
            return View(deliveryCar);
        }

        // GET: DeliveryCars/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliveryCar = await _context.DeliveryCar
                .FirstOrDefaultAsync(m => m.License_plate == id);
            if (deliveryCar == null)
            {
                return NotFound();
            }

            return View(deliveryCar);
        }

        // POST: DeliveryCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var deliveryCar = await _context.DeliveryCar.FindAsync(id);
            _context.DeliveryCar.Remove(deliveryCar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryCarExists(string id)
        {
            return _context.DeliveryCar.Any(e => e.License_plate == id);
        }
    }
}
