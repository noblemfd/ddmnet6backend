using Microsoft.AspNetCore.Identity;
using DDM.API.Core.Domain.Entities.IdentityModels;
using DDM.API.Core.Application.Enums;

namespace DDM.API.Infrastructure.Identity.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Merchant.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.BankUser.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.MerchantUser.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Customer.ToString()));
        }
    }
}
