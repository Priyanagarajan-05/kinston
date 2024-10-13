using Microsoft.AspNetCore.Mvc;

namespace Kinston_eUniversity.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            // Set a session variable
            HttpContext.Session.SetString("AdminName", "Admin User");

            // Retrieve a session variable
            var adminName = HttpContext.Session.GetString("AdminName");
            ViewBag.AdminName = adminName;

            return View();
        }
    }
}
