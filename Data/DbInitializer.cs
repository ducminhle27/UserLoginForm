using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserLoginForm.Models;

namespace UserLoginForm.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                context.Database.EnsureCreated();

                // Look for any users.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                var user = new ApplicationUser
                {
                    UserName = "huong@nuong.com",
                    Email = "huong@nuong.com",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(user, "1234");

                var admin = new ApplicationUser
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(admin, "Admin@1234");
            }
        }
    }
}
