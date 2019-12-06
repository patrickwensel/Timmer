using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Timmer.Web.Data;
using Timmer.Web.Models;

namespace Timmer.Web.Controllers
{
    public class ProductMakesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductMakesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductMakes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductMake.ToListAsync());
        }

        // GET: ProductMakes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMake = await _context.ProductMake
                .FirstOrDefaultAsync(m => m.ProductMakeID == id);
            if (productMake == null)
            {
                return NotFound();
            }

            return View(productMake);
        }

        // GET: ProductMakes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductMakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductMakeID,Name")] ProductMake productMake)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productMake);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productMake);
        }

        // GET: ProductMakes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMake = await _context.ProductMake.FindAsync(id);
            if (productMake == null)
            {
                return NotFound();
            }
            return View(productMake);
        }

        // POST: ProductMakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductMakeID,Name")] ProductMake productMake)
        {
            if (id != productMake.ProductMakeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productMake);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductMakeExists(productMake.ProductMakeID))
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
            return View(productMake);
        }

        // GET: ProductMakes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productMake = await _context.ProductMake
                .FirstOrDefaultAsync(m => m.ProductMakeID == id);
            if (productMake == null)
            {
                return NotFound();
            }

            return View(productMake);
        }

        // POST: ProductMakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productMake = await _context.ProductMake.FindAsync(id);
            _context.ProductMake.Remove(productMake);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductMakeExists(int id)
        {
            return _context.ProductMake.Any(e => e.ProductMakeID == id);
        }
    }
}
