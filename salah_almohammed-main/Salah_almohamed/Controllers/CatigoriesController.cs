using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Model;
using InfraStractur.DB_Context;
using Microsoft.AspNetCore.Authorization;

namespace Salah_almohamed.Controllers
{
    public class CatigoriesController : Controller
    {
        private readonly Context _context;

        public CatigoriesController(Context context)
        {
            _context = context;
        }

        // GET: Catigories

        public async Task<IActionResult> Index()
        {
            return View(await _context.catigories.ToListAsync());
        }

        [HttpGet("getcatigories")]
        public async Task<IActionResult> getcatigories(string Id)
        {
            var get=await _context.Users.Where(x=>x.Id==Id)
                .Include(x => x.userCatigories)
                .ToListAsync();
            return View("getcatigories");
        }

        // GET: Catigories/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catigory = await _context.catigories.Include(x=>x.seats)
                .FirstOrDefaultAsync(m => m.Id == id.ToString());
            if (catigory == null)
            {
                return NotFound();
            }

            return View(catigory);
        }

        // GET: Catigories/Create
        //[Authorize(Policy = "PoliceOwner")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Catigories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NameCatigory,Seats")] Catigory catigory)
        {
            if (ModelState.IsValid)
            {
                catigory.Id = Guid.NewGuid().ToString();
                _context.Add(catigory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catigory);
        }

        // GET: Catigories/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catigory = await _context.catigories.FindAsync(id);
            if (catigory == null)
            {
                return NotFound();
            }
            return View(catigory);
        }

        // POST: Catigories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,NameCatigory,bus")] Catigory catigory)
        {
            if (id != catigory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catigory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CatigoryExists(Guid.Parse(catigory.Id)))
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
            return View(catigory);
        }

        // GET: Catigories/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catigory = await _context.catigories
                .FirstOrDefaultAsync(m => m.Id == id.ToString());
            if (catigory == null)
            {
                return NotFound();
            }

            return View(catigory);
        }

        // POST: Catigories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var catigory = await _context.catigories.FindAsync(id);
            if (catigory != null)
            {
                _context.catigories.Remove(catigory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CatigoryExists(Guid id)
        {
            return _context.catigories.Any(e => e.Id == id.ToString());
        }
    }
}
