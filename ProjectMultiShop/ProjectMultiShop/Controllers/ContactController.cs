using Microsoft.AspNetCore.Mvc;

namespace ProjectMultiShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
