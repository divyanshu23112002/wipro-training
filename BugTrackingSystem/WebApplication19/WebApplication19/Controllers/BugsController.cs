using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication19.Data;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class BugsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly List<string> _validStatuses = new() { "Open", "In Progress", "Testing", "Closed" };
        private readonly List<string> _validSeverities = new() { "Low", "Medium", "High", "Critical" };

        public BugsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bugs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bugs.ToListAsync());
        }

        // GET: Bugs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bug = await _context.Bugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bug == null)
            {
                return NotFound();
            }

            return View(bug);
        }

        // GET: Bugs/Create
        public IActionResult Create()
        {
            ViewBag.StatusList = new SelectList(_validStatuses);
            ViewBag.SeverityList = new SelectList(_validSeverities);
            return View();
        }

        // POST: Bugs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,Severity,Status,Assignee")] Bug bug)
        {
            // Validate status and severity
            if (!_validStatuses.Contains(bug.Status))
            {
                ModelState.AddModelError("Status", "Invalid status value");
            }

            if (!_validSeverities.Contains(bug.Severity))
            {
                ModelState.AddModelError("Severity", "Invalid severity value");
            }

            if (ModelState.IsValid)
            {
                bug.ReportedDate = DateTime.Now;
                _context.Add(bug);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.StatusList = new SelectList(_validStatuses);
            ViewBag.SeverityList = new SelectList(_validSeverities);
            return View(bug);
        }

        // GET: Bugs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bug = await _context.Bugs.FindAsync(id);
            if (bug == null)
            {
                return NotFound();
            }

            ViewBag.StatusList = new SelectList(_validStatuses);
            ViewBag.SeverityList = new SelectList(_validSeverities);
            return View(bug);
        }

        // POST: Bugs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Severity,Status,Assignee,ReportedDate")] Bug bug)
        {
            if (id != bug.Id)
            {
                return NotFound();
            }

            // Validate status and severity
            if (!_validStatuses.Contains(bug.Status))
            {
                ModelState.AddModelError("Status", "Invalid status value");
            }

            if (!_validSeverities.Contains(bug.Severity))
            {
                ModelState.AddModelError("Severity", "Invalid severity value");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bug);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BugExists(bug.Id))
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

            ViewBag.StatusList = new SelectList(_validStatuses);
            ViewBag.SeverityList = new SelectList(_validSeverities);
            return View(bug);
        }

        // GET: Bugs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bug = await _context.Bugs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bug == null)
            {
                return NotFound();
            }

            return View(bug);
        }

        // POST: Bugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bug = await _context.Bugs.FindAsync(id);
            if (bug != null)
            {
                _context.Bugs.Remove(bug);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BugExists(int id)
        {
            return _context.Bugs.Any(e => e.Id == id);
        }

        // New action for getting status symbol
        public IActionResult GetStatusSymbol(string status)
        {
            var symbol = status switch
            {
                "Open" => "🟢",
                "In Progress" => "🟡",
                
                "Closed" => "🔴",
                _ => ""
            };
            return Content(symbol);
        }

        // New action for getting severity symbol
        public IActionResult GetSeveritySymbol(string severity)
        {
            var symbol = severity switch
            {
                "Low" => "⬇️",
                "Medium" => "⏺️",
                "High" => "⬆️",
                
                _ => ""
            };
            return Content(symbol);
        }
    }
}