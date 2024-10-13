/*
using Microsoft.AspNetCore.Mvc;
using Kinston_eUniversity.Data;
using Kinston_eUniversity.Models;

namespace Kinston_eUniversity.Controllers
{
    public class AdminController : Controller
    {
        private readonly KinstoneContext _context;

        public AdminController(KinstoneContext context)
        {
            _context = context;
        }

        // GET: Admin/Login
        public IActionResult Login() => View();

        // POST: Admin/Login
        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            var existingAdmin = _context.Admins.FirstOrDefault(a => a.Username == admin.Username && a.Password == admin.Password);
            if (existingAdmin != null)
            {
                // Logic for logged-in admin
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }

        // Create new admin logic here
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Admins.Add(admin);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(admin);
        }

        // Add, Suspend, or Remove Professor actions here
        //...
    }
}
*/



/* == 
 * 
using Microsoft.AspNetCore.Mvc;

namespace Kinston_eUniversity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Add your authentication logic here
            // If successful, redirect to the Admin dashboard
            return RedirectToAction("Index", "AdminDashboard");
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

    }
}
*/

using Microsoft.AspNetCore.Mvc;
using Kinston_eUniversity.Data;
using Kinston_eUniversity.Models;

namespace Kinston_eUniversity.Controllers
{
    public class AdminController : Controller
    {
        private readonly KinstoneContext _context;

        public AdminController(KinstoneContext context)
        {
            _context = context; // Use the injected DbContext
        }

        // GET: Admin/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Add your authentication logic here
            // If successful, redirect to the Admin dashboard
            return RedirectToAction("Index", "AdminDashboard");
        }

        // GET: Admin/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            if (ModelState.IsValid)
            {
                // Save the admin details to the database
                _context.Admins.Add(admin);
                _context.SaveChanges(); // Save changes to the database

                return RedirectToAction("Login");
            }
            return View(admin);
        }
    }
}
