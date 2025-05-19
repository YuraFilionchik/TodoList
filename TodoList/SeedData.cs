using Microsoft.AspNetCore.Identity;
using TodoList.Data;

namespace TodoList
{
    public static class SeedData
    {
        public static async Task EnsureAnonymousUserAsync(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            var user = await userManager.FindByEmailAsync(ApplicationUser.AnonymousUserMail);
            if (user is null)
            {
                user = new ApplicationUser
                {
                    UserName = ApplicationUser.AnonymousUserMail,
                    Email = ApplicationUser.AnonymousUserMail,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user, ApplicationUser.AnonymousUserPassword);
                if (!result.Succeeded)
                {
                    var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                    throw new Exception($"Failed to create a test user: {errors}");
                }
            }
        }
    }

}
