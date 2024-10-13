/*
using Microsoft.AspNetCore.Mvc;
using Kinston_eUniversity.Data;
using Kinston_eUniversity.Models;

namespace Kinston_eUniversity.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly KinstoneContext _context;

        public ProfessorController(KinstoneContext context)
        {
            _context = context;
        }

        // GET: Professor/Login
        public IActionResult Login() => View();

        // POST: Professor/Login
        [HttpPost]
        public IActionResult Login(Professor professor)
        {
            var existingProfessor = _context.Professors.FirstOrDefault(p => p.Username == professor.Username && p.Password == professor.Password);
            if (existingProfessor != null)
            {
                // Logic for logged-in professor
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }

        // Logic for creating new course and updating it
        public IActionResult CreateCourse() => View();

        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View(course);
        }

        // View students enrolled in the course
        //...
    }
}
*/

using Microsoft.AspNetCore.Mvc;
using Kinston_eUniversity.Data;
using Kinston_eUniversity.Models;
using System.Linq;

namespace Kinston_eUniversity.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly KinstoneContext _context;

        public ProfessorController(KinstoneContext context)
        {
            _context = context;
        }

        // GET: Professor/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Professor/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Check if professor exists with the provided credentials
            var professor = _context.Professors.FirstOrDefault(p => p.Username == username && p.Password == password);

            if (professor != null)
            {
                // If credentials are correct, redirect to Professor dashboard
                return RedirectToAction("Index", "ProfessorDashboard");
            }
            else
            {
                // If credentials are incorrect, show error
                ViewBag.Message = "Invalid Username or Password";
                return View();
            }
        }

        // GET: Professor/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        public IActionResult Create(Professor professor)
        {
            if (ModelState.IsValid)
            {
                // Save the new professor to the database
                _context.Professors.Add(professor);
                _context.SaveChanges();

                return RedirectToAction("Login");
            }

            return View(professor);
        }
    }
}
