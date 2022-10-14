using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GadaElectronics.Data;
using GadaElectronics.Models;

namespace GadaElectronics.Controllers
{
    public class TonyTvsController : Controller
    {
        private readonly GadaElectronicsContext _context;

        public TonyTvsController(GadaElectronicsContext context)
        {
            _context = context;
        }

        // GET: TonyTvs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TonyTv.ToListAsync());
        }

        // GET: TonyTvs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tonyTv = await _context.TonyTv
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tonyTv == null)
            {
                return NotFound();
            }

            return View(tonyTv);
        }

        // GET: TonyTvs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TonyTvs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Price,OriginCountry,SerialNumber,DisplayClearity,Size")] TonyTv tonyTv)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tonyTv);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tonyTv);
        }

        // GET: TonyTvs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tonyTv = await _context.TonyTv.FindAsync(id);
            if (tonyTv == null)
            {
                return NotFound();
            }
            return View(tonyTv);
        }

        // POST: TonyTvs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Price,OriginCountry,SerialNumber,DisplayClearity,Size")] TonyTv tonyTv)
        {
            if (id != tonyTv.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tonyTv);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TonyTvExists(tonyTv.Id))
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
            return View(tonyTv);
        }

        // GET: TonyTvs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tonyTv = await _context.TonyTv
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tonyTv == null)
            {
                return NotFound();
            }

            return View(tonyTv);
        }

        // POST: TonyTvs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tonyTv = await _context.TonyTv.FindAsync(id);
            _context.TonyTv.Remove(tonyTv);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TonyTvExists(int id)
        {
            return _context.TonyTv.Any(e => e.Id == id);
        }
    }
}
