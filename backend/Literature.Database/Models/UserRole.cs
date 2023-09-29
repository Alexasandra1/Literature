using Microsoft.AspNetCore.Identity;

namespace Literature.Database.Models
{
    public class UserRole : IdentityUserRole<string>
    {
        public virtual IdentityRole Role { get; set; }

        public virtual User User { get; set; }
    }
}
