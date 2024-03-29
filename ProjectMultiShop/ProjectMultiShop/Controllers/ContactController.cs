﻿using Microsoft.AspNetCore.Mvc;
using ProjectMultiShop.Context;
using ProjectMultiShop.Models;

namespace ProjectMultiShop.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
