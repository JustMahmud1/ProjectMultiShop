using Microsoft.AspNetCore.Mvc;
using ProjectMultiShop.Context;
using ProjectMultiShop.Models;

namespace ProjectMultiShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Contact> contacts = _context.Contacts.ToList();
            return View(contacts);
        }

        
        public IActionResult Delete(int Id)
        {
            Contact contact = _context.Contacts.Find(Id);
            _context.Contacts.Remove(contact);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
