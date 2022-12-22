using Microsoft.AspNetCore.Mvc;

namespace ProjectMultiShop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopDetail()
        {
            return View();
        }
    }
}
