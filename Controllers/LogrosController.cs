using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistGestNotas.Data;
using SistGestNotas.Models;

namespace SistGestNotas.Controllers
{
    public class LogrosController : Controller
    {
        private readonly AppDbContext _context;

        public LogrosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Logros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Logros.ToListAsync());
        }

        // GET: Logros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logros = await _context.Logros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logros == null)
            {
                return NotFound();
            }

            return View(logros);
        }

        // GET: Logros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Logros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreLogro,DetalleLogro")] Logros logros)
        {
            if (ModelState.IsValid)
            {
                _context.Add(logros);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(logros);
        }

        // GET: Logros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logros = await _context.Logros.FindAsync(id);
            if (logros == null)
            {
                return NotFound();
            }
            return View(logros);
        }

        // POST: Logros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreLogro,DetalleLogro")] Logros logros)
        {
            if (id != logros.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(logros);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LogrosExists(logros.Id))
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
            return View(logros);
        }

        // GET: Logros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logros = await _context.Logros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (logros == null)
            {
                return NotFound();
            }

            return View(logros);
        }

        // POST: Logros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var logros = await _context.Logros.FindAsync(id);
            if (logros != null)
            {
                _context.Logros.Remove(logros);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LogrosExists(int id)
        {
            return _context.Logros.Any(e => e.Id == id);
        }
    }
}
