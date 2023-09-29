using Microsoft.AspNetCore.Identity;

namespace Literature.Database.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public ICollection<UserRole> Roles { get; set; }

        public ICollection<New> News { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
