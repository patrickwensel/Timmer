using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Timmer.Web.Data;
using Timmer.Web.Models;

namespace Timmer.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductLocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductLocations.ToListAsync());
        }

        // GET: ProductLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productLocation = await _context.ProductLocations
                .FirstOrDefaultAsync(m => m.ProductLocationID == id);
            if (productLocation == null)
            {
                return NotFound();
            }

            return View(productLocation);
        }

        // GET: ProductLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductLocationID,Name")] ProductLocation productLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productLocation);
        }

        // GET: ProductLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productLocation = await _context.ProductLocations.FindAsync(id);
            if (productLocation == null)
            {
                return NotFound();
            }
            return View(productLocation);
        }

        // POST: ProductLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductLocationID,Name")] ProductLocation productLocation)
        {
            if (id != productLocation.ProductLocationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductLocationExists(productLocation.ProductLocationID))
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
            return View(productLocation);
        }

        // GET: ProductLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productLocation = await _context.ProductLocations
                .FirstOrDefaultAsync(m => m.ProductLocationID == id);
            if (productLocation == null)
            {
                return NotFound();
            }

            return View(productLocation);
        }

        // POST: ProductLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productLocation = await _context.ProductLocations.FindAsync(id);
            _context.ProductLocations.Remove(productLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductLocationExists(int id)
        {
            return _context.ProductLocations.Any(e => e.ProductLocationID == id);
        }
    }
}
