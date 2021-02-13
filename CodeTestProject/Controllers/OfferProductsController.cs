using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeTestProject.Models;

namespace CodeTestProject.Controllers
{
    public class OfferProductsController : Controller
    {
        private readonly CodeTestContext _context;

        public OfferProductsController(CodeTestContext context)
        {
            _context = context;
        }

        // GET: OfferProducts
        public async Task<IActionResult> Index()
        {
            var codeTestContext = _context.OfferProduct.Include(o => o.Offer).Include(o => o.Product);
            return View(await codeTestContext.ToListAsync());
        }

        // GET: OfferProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerProduct = await _context.OfferProduct
                .Include(o => o.Offer)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.OfferProductID == id);
            if (offerProduct == null)
            {
                return NotFound();
            }

            return View(offerProduct);
        }

        // GET: OfferProducts/Create
        public IActionResult Create()
        {
            ViewData["OfferName"] = new SelectList(_context.Offer, "OfferName", "OfferName");
            ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductID");
            return View();
        }

        // POST: OfferProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OfferProductID,OfferName,ProductID")] OfferProduct offerProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(offerProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OfferName"] = new SelectList(_context.Offer, "OfferName", "OfferName", offerProduct.OfferName);
            ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductID", offerProduct.ProductID);
            return View(offerProduct);
        }

        // GET: OfferProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerProduct = await _context.OfferProduct.FindAsync(id);
            if (offerProduct == null)
            {
                return NotFound();
            }
            ViewData["OfferName"] = new SelectList(_context.Offer, "OfferName", "OfferName", offerProduct.OfferName);
            ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductID", offerProduct.ProductID);
            return View(offerProduct);
        }

        // POST: OfferProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OfferProductID,OfferName,ProductID")] OfferProduct offerProduct)
        {
            if (id != offerProduct.OfferProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offerProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfferProductExists(offerProduct.OfferProductID))
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
            ViewData["OfferName"] = new SelectList(_context.Offer, "OfferName", "OfferName", offerProduct.OfferName);
            ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "ProductID", offerProduct.ProductID);
            return View(offerProduct);
        }

        // GET: OfferProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offerProduct = await _context.OfferProduct
                .Include(o => o.Offer)
                .Include(o => o.Product)
                .FirstOrDefaultAsync(m => m.OfferProductID == id);
            if (offerProduct == null)
            {
                return NotFound();
            }

            return View(offerProduct);
        }

        // POST: OfferProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offerProduct = await _context.OfferProduct.FindAsync(id);
            _context.OfferProduct.Remove(offerProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfferProductExists(int id)
        {
            return _context.OfferProduct.Any(e => e.OfferProductID == id);
        }
    }
}
