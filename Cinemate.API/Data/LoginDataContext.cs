using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.API.Data
{
    public class LoginDataContext : IdentityDbContext
    {
        public LoginDataContext(DbContextOptions<LoginDataContext> options) : base(options)
        {
            
        }
    }
}
