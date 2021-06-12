using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _012.Data;
using _012.Models;

namespace _012.Controllers
{
    public class CardTranController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CardTranController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CardTran
        public async Task<IActionResult> Index()
        {
            return View(await _context.CardT.ToListAsync());
        }

        // GET: CardTran/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.CardT
                .FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // GET: CardTran/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CardTran/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CardNumber,CardAccount,CardBalance,CardHolderId,CardHolderName,expiryDate,cvi,changeBalance")] Card card)
        {
            if (ModelState.IsValid)
            {
                _context.Add(card);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(card);
        }

        // GET: CardTran/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.CardT.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            return View(card);
        }

        // POST: CardTran/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, 
            [Bind("Id,CardNumber,CardAccount,CardBalance,CardHolderId," +
            "CardHolderName,expiryDate,cvi,changeBalance")] Card card)
        {
            if (id != card.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(card);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardExists(card.Id))
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
            return View(card);
        }

        // GET: CardTran/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var card = await _context.CardT
                .FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // POST: CardTran/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var card = await _context.CardT.FindAsync(id);
            _context.CardT.Remove(card);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardExists(int id)
        {
            return _context.CardT.Any(e => e.Id == id);
        }
    }
}
