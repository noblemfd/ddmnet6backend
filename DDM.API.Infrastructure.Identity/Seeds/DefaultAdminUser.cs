using Microsoft.AspNetCore.Identity;
using DDM.API.Core.Domain.Entities.IdentityModels;
using DDM.API.Core.Application.Enums;
using Microsoft.Extensions.Logging;
//using Org.BouncyCastle.Crypto.Prng.Drbg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDM.API.Infrastructure.Identity.Seeds
{
    public static class DefaultAdmin
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "admin",
                Email = "admin@africa.int.zenithbank.com",
                NormalizedEmail = "ADMIN@AFRICA.INT.ZENITHBANK.COM",
                FirstName = "AdminFN",
                LastName = "AdminLN",
                NormalizedUserName = "ADMIN",
                MobileNumber = "1234567890",
                PhoneNumber = "+1234567890"
                //EmailConfirmed = true,
                //PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.UserName != defaultUser.UserName))
            {
                var user = await userManager.FindByNameAsync(defaultUser.UserName);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Admin*123!");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Merchant.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.BankUser.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.MerchantUser.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Customer.ToString());
                }

            }
        }
    }
}
