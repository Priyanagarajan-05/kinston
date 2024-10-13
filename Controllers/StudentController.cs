/*
using Microsoft.AspNetCore.Mvc;
using Kinston_eUniversity.Data;
using Kinston_eUniversity.Models;

namespace Kinston_eUniversity.Controllers
{
    public class StudentController : Controller
    {
        private readonly KinstoneContext _context;

        public StudentController(KinstoneContext context)
        {
            _context = context;
        }

        // GET: Student/Login
        public IActionResult Login() => View();

        // POST: Student/Login
        [HttpPost]
        public IActionResult Login(Student student)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.Username == student.Username && s.Password == student.Password);
            if (existingStudent != null)
            {
                // Logic for logged-in student
                return RedirectToAction("CourseList");
            }
            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }

        // Register for a course and handle payment
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
    public class StudentController : Controller
    {
        private readonly KinstoneContext _context;

        public StudentController(KinstoneContext context)
        {
            _context = context;
        }

        // GET: Student/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Student/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Check if student exists with the provided credentials
            var student = _context.Students.FirstOrDefault(s => s.Username == username && s.Password == password);

            if (student != null)
            {
                // If credentials are correct, redirect to Student dashboard
                return RedirectToAction("Index", "StudentDashboard");
            }
            else
            {
                // If credentials are incorrect, show error
                ViewBag.Message = "Invalid Username or Password";
                return View();
            }
        }
    }
}
