﻿using Microsoft.AspNetCore.Mvc;
using ProjectMultiShop.Context;
using ProjectMultiShop.Models;

namespace ProjectMultiShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]

        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(int Id, Category category)
        {
            Category newcategory = _context.Categories.Find(category.Id);
            newcategory.Name = category.Name;
            newcategory.ImgPath = category.ImgPath;
            _context.Categories.Update(newcategory);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
