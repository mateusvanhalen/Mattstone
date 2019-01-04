using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mattstone.Data;
using Mattstone.Models;
using Mattstone.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Mattstone.Controllers
{
    public class ChoresController : Controller
    {
        private readonly ApplicationDbContext _context;
        //Id Framework
        private readonly UserManager<ApplicationUser> _userManager;

        public ChoresController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            //using Id Framework
            _userManager = userManager;
        }
        //Id Framework also
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        //GET: Chores
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();

            var choreList = _context.Chore
                .Include(c => c.Day)
                .Include(u => u.User)
                // this otion here for showing only user chores
                //.Where(c => c.UserId == user.Id)
                .ToList();
            if (choreList == null)
            {
                return NotFound();
            }
            ChoreIndexViewModel viewmodel = new ChoreIndexViewModel()
            {
                Chores = choreList,
                IsParent = user.IsParent

            };

            return View(viewmodel);

            //viewmodel.ChoreList = Chore

            
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Chores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chore = await _context.Chore
                .FirstOrDefaultAsync(m => m.ChoreId == id);
            if (chore == null)
            {
                return NotFound();
            }

            return View(chore);
        }

        // GET: Chores/Create
        public async Task<IActionResult> Create()
        {
            ChoresCreateViewModel viewmodel = new ChoresCreateViewModel(_context);
            return View(viewmodel);
        }

        // POST: Chores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ChoresCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model.Chore);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DayId"] = new SelectList(_context.Day, "DayId", "DayName", model.Chore.Day);
            ViewData["UserId"] = new SelectList(_context.ApplicationUser, "UserId", "UserName", model.Chore.User);
            return View(model);
           
            //refer view model User Text and Valus//
           
        }
        // GET: Chores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        { 
            //setting condition if there is no ID or no ID match to databse, return Not found from the null response
            if (id == null)
            {
                return NotFound();
            }
            //the response from the async (await) for the context(what is grabbing properties) for chore ad finidng the id that is binded
            var chore = await _context.Chore.FindAsync(id);
            // if the property of chore returns null throw a NotFound message 
            if (chore == null)
            {
                return NotFound();
            }
            // using the viewmodel variable from ChoresEditViewModel, create a new instance from the context method
            ChoresEditViewModel viewmodel = new ChoresEditViewModel(_context);
            //using the viewmodel variable's property chore(as an object), define it as chore. This will let us use the information from the created chore to display 
            viewmodel.Chore = chore;
            //return the viewmodel variable with new information 
            return View(viewmodel); ;
        }

        // POST: Chores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ChoresEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Update(model.Chore);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DayId"] = new SelectList(_context.Day, "DayId", "DayName", new { id = model.Chore.ChoreId});
            return View(model);

        }

            // GET: Chores/Delete/5
            public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chore = await _context.Chore
                .FirstOrDefaultAsync(m => m.ChoreId == id);
            if (chore == null)
            {
                return NotFound();
            }

            return View(chore);
        }

        // POST: Chores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chore = await _context.Chore.FindAsync(id);
            _context.Chore.Remove(chore);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChoreExists(int id)
        {
            return _context.Chore.Any(e => e.ChoreId == id);
        }
    }
}
