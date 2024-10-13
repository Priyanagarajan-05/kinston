using Microsoft.AspNetCore.Mvc;
using Kinston_eUniversity.Data; // Assuming your DbContext is in this namespace
using Kinston_eUniversity.Models; // Assuming you have User model defined here

public class AccountController : Controller
{
    private readonly KinstoneContext _context;

    public AccountController(KinstoneContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult LoginOrCreate(string email, string password, string role)
    {
        // Check if the user exists
        var user = _context.Users.SingleOrDefault(u => u.Email == email);

        if (user != null)
        {
            // User exists; check the password
            if (user.Password == password) // Ensure you hash and compare passwords in a real application
            {
                // Set session or authentication cookie here
                HttpContext.Session.SetString("AdminName", user.Name); // Assuming you have a Name field
                return RedirectToAction("Index", role); // Redirect to corresponding dashboard
            }
            else
            {
                ModelState.AddModelError("", "Invalid password.");
                return View();
            }
        }
        else
        {
            // User doesn't exist; create a new account
            user = new User // Assuming you have a User model
            {
                Email = email,
                Password = password, // Hash this password before storing
                Role = role // Store role information
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            HttpContext.Session.SetString("AdminName", user.Name); // Assuming you have a Name field
            return RedirectToAction("Index", role); // Redirect to corresponding dashboard
        }
    }
}
