using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OMAF.Data;
using OMAF.Models;

namespace OMAF.Controllers
{
    public class AircraftController : Controller
    {
        private readonly OmafContext _context;

        public AircraftController(OmafContext context)
        {
            _context = context;
        }

        // GET: Aircraft
        public async Task<IActionResult> Index(string aircraftBuno, string searchString)
        {
            // Use LINQ to get list of genres.                              //Changed m to a.
            IQueryable<string> bunoQuery = from a in _context.Aircraft
                                            orderby a.Buno
                                            select a.Buno;

            var aircraft = from a in _context.Aircraft
                         select a;

            if (!string.IsNullOrEmpty(searchString))
            {
                aircraft = aircraft.Where(s => s.SysReason.Contains(searchString));         //Keot s for searchString
            }

            if (!string.IsNullOrEmpty(aircraftBuno))
            {
                aircraft = aircraft.Where(b => b.Buno == aircraftBuno);         //Changed x to b.
            }

            var aircraftBunoVM = new AircraftBunoViewModel
            {
                Buno = new SelectList(await bunoQuery.Distinct().ToListAsync()),
                Aircraft = await aircraft.ToListAsync()
            };

            return View(aircraftBunoVM);
        }
        public async Task<IActionResult> Index2(string searchString)
        {
            var aircraft = from a in _context.Aircraft
                         select a;

            if (!String.IsNullOrEmpty(searchString))
            {
                aircraft = aircraft.Where(s => s.SysReason.Contains(searchString)); //Contains runs on the database and not on C#.
            }

            return View(await aircraft.ToListAsync());
        }
        public async Task<IActionResult> Index1()
        {
            return View(await _context.Aircraft.ToListAsync());
        }

        // GET: Aircraft/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aircraft = await _context.Aircraft
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aircraft == null)
            {
                return NotFound();
            }

            return View(aircraft);
        }

        // GET: Aircraft/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aircraft/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Buno,SysReason,ReleaseDate,UDP,JobStat")] Aircraft aircraft)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aircraft);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aircraft);
        }

        // GET: Aircraft/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aircraft = await _context.Aircraft.FindAsync(id);
            if (aircraft == null)
            {
                return NotFound();
            }
            return View(aircraft);
        }

        // POST: Aircraft/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Buno,SysReason,ReleaseDate,UDP,JobStat")] Aircraft aircraft)
        {
            if (id != aircraft.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aircraft);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AircraftExists(aircraft.Id))
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
            return View(aircraft);
        }

        // GET: Aircraft/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aircraft = await _context.Aircraft
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aircraft == null)
            {
                return NotFound();
            }

            return View(aircraft);
        }

        // POST: Aircraft/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aircraft = await _context.Aircraft.FindAsync(id);
            _context.Aircraft.Remove(aircraft);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AircraftExists(int id)
        {
            return _context.Aircraft.Any(e => e.Id == id);
        }
    }
}
