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
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Products.Include(p => p.ProductCategory).Include(p => p.ProductLocation).Include(p => p.ProductMake);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.ProductLocation)
                .Include(p => p.ProductMake)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "ProductCategoryID", "ProductCategoryID");
            ViewData["ProductLocationID"] = new SelectList(_context.ProductLocations, "ProductLocationID", "ProductLocationID");
            ViewData["ProductMakeID"] = new SelectList(_context.ProductMake, "ProductMakeID", "ProductMakeID");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,Image,Url,Title,Description,NewUsed,StockNumber,Year,Hours,EngineHorsePower,Drive,SerialNumber,Price,Model,ProductCategoryID,ProductLocationID,ProductMakeID")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "ProductCategoryID", "ProductCategoryID", product.ProductCategoryID);
            ViewData["ProductLocationID"] = new SelectList(_context.ProductLocations, "ProductLocationID", "ProductLocationID", product.ProductLocationID);
            ViewData["ProductMakeID"] = new SelectList(_context.ProductMake, "ProductMakeID", "ProductMakeID", product.ProductMakeID);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "ProductCategoryID", "ProductCategoryID", product.ProductCategoryID);
            ViewData["ProductLocationID"] = new SelectList(_context.ProductLocations, "ProductLocationID", "ProductLocationID", product.ProductLocationID);
            ViewData["ProductMakeID"] = new SelectList(_context.ProductMake, "ProductMakeID", "ProductMakeID", product.ProductMakeID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,Image,Url,Title,Description,NewUsed,StockNumber,Year,Hours,EngineHorsePower,Drive,SerialNumber,Price,Model,ProductCategoryID,ProductLocationID,ProductMakeID")] Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductID))
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
            ViewData["ProductCategoryID"] = new SelectList(_context.ProductCategories, "ProductCategoryID", "ProductCategoryID", product.ProductCategoryID);
            ViewData["ProductLocationID"] = new SelectList(_context.ProductLocations, "ProductLocationID", "ProductLocationID", product.ProductLocationID);
            ViewData["ProductMakeID"] = new SelectList(_context.ProductMake, "ProductMakeID", "ProductMakeID", product.ProductMakeID);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductCategory)
                .Include(p => p.ProductLocation)
                .Include(p => p.ProductMake)
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductID == id);
        }
    }
}
