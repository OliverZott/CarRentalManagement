using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement.Server.Models
{
    // Related to ApplicationDbContext.cs!
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
