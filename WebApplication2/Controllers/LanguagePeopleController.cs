using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LanguagePeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LanguagePeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // List
        public IActionResult Index()
        {
            var langList = _context.LanguagePeople.Include(l => l.Language).Include(l => l.Person);
            return View(langList.ToList());
        }


        // Create
        public IActionResult Create()
        {
            ViewData["LanguageName"] = new SelectList(_context.Languages1, "LanguageName", "LanguageName");
            ViewData["PersonId"] = new SelectList(_context.People, "PeopleId", "Name");
            return View();
        }

        
        [HttpPost]
        public IActionResult Create(LanguagePerson languagePerson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(languagePerson);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["LanguageName"] = new SelectList(_context.Languages1, "LanguageName", "LanguageName", languagePerson.LanguageName);
            ViewData["PersonId"] = new SelectList(_context.People, "PeopleId", "Name", languagePerson.PersonId);
            return View(languagePerson);
        }
        
    }
}
