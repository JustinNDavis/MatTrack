using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MatTrack.Data;
using MatTrack.Models;

namespace MatTrack.Controllers
{
    public class UpcomingEventsController : Controller
    {
        private readonly MatTrackContext _context;

        public UpcomingEventsController(MatTrackContext context)
        {
            _context = context;
        }

        // GET: UpcomingEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.UpcomingEvents.ToListAsync());
        }

        // GET: UpcomingEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upcomingEvents = await _context.UpcomingEvents
                .FirstOrDefaultAsync(m => m.UpcomingEventsID == id);
            if (upcomingEvents == null)
            {
                return NotFound();
            }

            return View(upcomingEvents);
        }

        // GET: UpcomingEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UpcomingEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UpcomingEventsID,Title,EventSummary,EventPrice,EventDate")] UpcomingEvents upcomingEvents)
        {
            if (ModelState.IsValid)
            {
                _context.Add(upcomingEvents);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(upcomingEvents);
        }

        // GET: UpcomingEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upcomingEvents = await _context.UpcomingEvents.FindAsync(id);
            if (upcomingEvents == null)
            {
                return NotFound();
            }
            return View(upcomingEvents);
        }

        // POST: UpcomingEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UpcomingEventsID,Title,EventSummary,EventPrice,EventDate")] UpcomingEvents upcomingEvents)
        {
            if (id != upcomingEvents.UpcomingEventsID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(upcomingEvents);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UpcomingEventsExists(upcomingEvents.UpcomingEventsID))
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
            return View(upcomingEvents);
        }

        // GET: UpcomingEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upcomingEvents = await _context.UpcomingEvents
                .FirstOrDefaultAsync(m => m.UpcomingEventsID == id);
            if (upcomingEvents == null)
            {
                return NotFound();
            }

            return View(upcomingEvents);
        }

        // POST: UpcomingEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var upcomingEvents = await _context.UpcomingEvents.FindAsync(id);
            _context.UpcomingEvents.Remove(upcomingEvents);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UpcomingEventsExists(int id)
        {
            return _context.UpcomingEvents.Any(e => e.UpcomingEventsID == id);
        }
    }
}
