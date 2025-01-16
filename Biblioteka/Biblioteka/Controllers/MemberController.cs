using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteka.Data;
using Biblioteka.Models;
using Microsoft.AspNetCore.Authorization;

namespace Biblioteka.Controllers
{   
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MemberController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Member
        public async Task<IActionResult> Index()
        {
            return View(await _context.Members.ToListAsync());
        }

        // GET: Member/Details/5

        [Authorize(Roles = "Admin, Użytkownik")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberEntity = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memberEntity == null)
            {
                return NotFound();
            }

            return View(memberEntity);
        }

        // GET: Member/Create

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        // POST: Member/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,PhoneNumber,Email")] MemberEntity memberEntity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(memberEntity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(memberEntity);
        }

        [Authorize(Roles = "Admin")]
        // GET: Member/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberEntity = await _context.Members.FindAsync(id);
            if (memberEntity == null)
            {
                return NotFound();
            }
            return View(memberEntity);
        }

        // POST: Member/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,PhoneNumber,Email")] MemberEntity memberEntity)
        {
            if (id != memberEntity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(memberEntity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberEntityExists(memberEntity.Id))
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
            return View(memberEntity);
        }

        // GET: Member/Delete/5

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var memberEntity = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (memberEntity == null)
            {
                return NotFound();
            }

            return View(memberEntity);
        }

        // POST: Member/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var memberEntity = await _context.Members.FindAsync(id);
            if (memberEntity != null)
            {
                _context.Members.Remove(memberEntity);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberEntityExists(int id)
        {
            return _context.Members.Any(e => e.Id == id);
        }
    }
}
