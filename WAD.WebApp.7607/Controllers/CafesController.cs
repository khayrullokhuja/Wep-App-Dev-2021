using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WAD.DAL._7607;
using WAD.DAL._7607.DBO;

namespace WAD.WebApp._7607.Controllers
{
    public class CafesController : Controller
    {
        private readonly SocialsCafeDbContext _context;

        public CafesController(SocialsCafeDbContext context)
        {
            _context = context;
        }

        // GET: Cafes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cafe.ToListAsync());
        }

        // GET: Cafes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cafe = await _context.Cafe
                .FirstOrDefaultAsync(m => m.CafeId == id);
            if (cafe == null)
            {
                return NotFound();
            }

            return View(cafe);
        }

        // GET: Cafes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cafes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CafeId,CafeName,Email")] Cafe cafe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cafe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cafe);
        }

        // GET: Cafes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cafe = await _context.Cafe.FindAsync(id);
            if (cafe == null)
            {
                return NotFound();
            }
            return View(cafe);
        }

        // POST: Cafes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CafeId,CafeName,Email")] Cafe cafe)
        {
            if (id != cafe.CafeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cafe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CafeExists(cafe.CafeId))
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
            return View(cafe);
        }

        // GET: Cafes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cafe = await _context.Cafe
                .FirstOrDefaultAsync(m => m.CafeId == id);
            if (cafe == null)
            {
                return NotFound();
            }

            return View(cafe);
        }

        // POST: Cafes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cafe = await _context.Cafe.FindAsync(id);
            _context.Cafe.Remove(cafe);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CafeExists(int id)
        {
            return _context.Cafe.Any(e => e.CafeId == id);
        }
    }
}
