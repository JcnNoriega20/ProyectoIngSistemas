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
    public class PeriodoAcademicoController : Controller
    {
        private readonly AppDbContext _context;

        public PeriodoAcademicoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: PeriodoAcademico
        public async Task<IActionResult> Index()
        {
            return View(await _context.PeriodoAcademico.ToListAsync());
        }

        // GET: PeriodoAcademico/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodoAcademico = await _context.PeriodoAcademico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodoAcademico == null)
            {
                return NotFound();
            }

            return View(periodoAcademico);
        }

        // GET: PeriodoAcademico/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PeriodoAcademico/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombrePeriodo,FechaInicio,FechaFin")] PeriodoAcademico periodoAcademico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(periodoAcademico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(periodoAcademico);
        }

        // GET: PeriodoAcademico/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodoAcademico = await _context.PeriodoAcademico.FindAsync(id);
            if (periodoAcademico == null)
            {
                return NotFound();
            }
            return View(periodoAcademico);
        }

        // POST: PeriodoAcademico/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombrePeriodo,FechaInicio,FechaFin")] PeriodoAcademico periodoAcademico)
        {
            if (id != periodoAcademico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(periodoAcademico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeriodoAcademicoExists(periodoAcademico.Id))
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
            return View(periodoAcademico);
        }

        // GET: PeriodoAcademico/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periodoAcademico = await _context.PeriodoAcademico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (periodoAcademico == null)
            {
                return NotFound();
            }

            return View(periodoAcademico);
        }

        // POST: PeriodoAcademico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var periodoAcademico = await _context.PeriodoAcademico.FindAsync(id);
            if (periodoAcademico != null)
            {
                _context.PeriodoAcademico.Remove(periodoAcademico);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeriodoAcademicoExists(int id)
        {
            return _context.PeriodoAcademico.Any(e => e.Id == id);
        }
    }
}
