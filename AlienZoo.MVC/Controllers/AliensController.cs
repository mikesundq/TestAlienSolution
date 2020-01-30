using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlienZoo.Infrastructure.Persistance;
using AlienZooDomain;

namespace AlienZoo.MVC.Controllers
{
    public class AliensController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AliensController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Aliens
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Alien.Include(a => a.Handler);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Aliens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alien = await _context.Alien
                .Include(a => a.Handler)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alien == null)
            {
                return NotFound();
            }

            return View(alien);
        }

        // GET: Aliens/Create
        public IActionResult Create()
        {
            ViewData["HandlerID"] = new SelectList(_context.Person, "Id", "Id");
            return View();
        }

        // POST: Aliens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Age,HandlerID,Name,Color,Origin,AlienType")] Alien alien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HandlerID"] = new SelectList(_context.Person, "Id", "Id", alien.HandlerID);
            return View(alien);
        }

        // GET: Aliens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alien = await _context.Alien.FindAsync(id);
            if (alien == null)
            {
                return NotFound();
            }
            ViewData["HandlerID"] = new SelectList(_context.Person, "Id", "Id", alien.HandlerID);
            return View(alien);
        }

        // POST: Aliens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Age,HandlerID,Name,Color,Origin,AlienType")] Alien alien)
        {
            if (id != alien.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlienExists(alien.Id))
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
            ViewData["HandlerID"] = new SelectList(_context.Person, "Id", "Id", alien.HandlerID);
            return View(alien);
        }

        // GET: Aliens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alien = await _context.Alien
                .Include(a => a.Handler)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alien == null)
            {
                return NotFound();
            }

            return View(alien);
        }

        // POST: Aliens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alien = await _context.Alien.FindAsync(id);
            _context.Alien.Remove(alien);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlienExists(int id)
        {
            return _context.Alien.Any(e => e.Id == id);
        }
    }
}
