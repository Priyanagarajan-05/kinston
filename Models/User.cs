namespace Kinston_eUniversity.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Store hashed password in real applications
        public string Role { get; set; }
        public string Name { get; set; } // Assuming you have a Name field
    }


}
