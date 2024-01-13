using Microsoft.AspNetCore.Identity;

namespace WebApp6.Models
{
    public class ApplicationUser:IdentityUser
    {
        public String Name {  get; set; }
        public String Address { get; set; }
    }
}
