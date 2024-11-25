using BlazorEcommerce.Identity;
using BlazorEcommerce.Identity.Contexts;
using BlazorEcommerce.Shared.Constant;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorEcommerce.Persistence.Contexts;

public class UserIdentityDbContextInitialiser
{
    private readonly UserIdentityDbContext _context;

    public UserIdentityDbContextInitialiser(UserIdentityDbContext context)
    {
        _context = context;
    }

    public async Task InitialiseAsync()
    {
        await InitialiseWithMigrationsAsync();
    }

    private async Task InitialiseWithMigrationsAsync()
    {
        if (_context.Database.IsSqlServer())
        {
            await _context.Database.MigrateAsync();
        }
        else
        {
            await _context.Database.EnsureCreatedAsync();
        }
    }

    public async Task SeedData(IServiceScope scope)
    {
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        var adminEmail = Constants.AdminEmail;
        var existinAdmingUser = await userManager.FindByEmailAsync(adminEmail);
        if (existinAdmingUser == null)
        {
            var adminUser = new ApplicationUser
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                Email = adminEmail,
                NormalizedEmail = adminEmail.ToUpper(),
                FirstName = "System",
                LastName = "Admin",
                UserName = adminEmail,
                NormalizedUserName = adminEmail.ToUpper(),
                EmailConfirmed = true
            };

            await userManager.CreateAsync(adminUser, "P@ssw0rd");
            await userManager.AddToRoleAsync(adminUser, Constants.AdminRoleName);
        }

        var userEmail = Constants.TestUserEmail;
        var existingTestUser = await userManager.FindByEmailAsync(userEmail);
        if (existingTestUser == null)
        {
            var testUser = new ApplicationUser
            {
                Id = "974303e0-6275-4a3f-82f9-8e961e57a7fd",
                Email = userEmail,
                NormalizedEmail = userEmail.ToUpper(),
                FirstName = "Randy",
                LastName = "Gamage",
                UserName = userEmail,
                NormalizedUserName = userEmail.ToUpper(),
                EmailConfirmed = true
            };

            await userManager.CreateAsync(testUser, "P@ssw0rd");
            await userManager.AddToRoleAsync(testUser, Constants.TestUserRoleName);
        }
    }
}
