using Microsoft.AspNetCore.Identity;

namespace ecommerce_1.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string NrPhone { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
