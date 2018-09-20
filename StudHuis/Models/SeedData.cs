using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StudHuis.Models
{
    public class SeedData
    {
        private const string adminUser = "Chef";
        private const string adminPassword = "Secret";

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Meals.Any())
            {
                context.Meals.AddRange(
                    new Meal
                    {
                        Name = "Spaget NANI",
                        Description = "Beste spaget",
                        MaxGuests = 200,
                        Price = 6.66,
                        MealTime = new DateTime(2018, 1, 1)
                    },
                    new Meal
                    {
                        Name = "NANI Spaget 2",
                        Description = "Beste spaget 2",
                        MaxGuests = 200,
                        Price = 6.66,
                        MealTime = new DateTime(2018, 1, 1)
                    }
                );
                context.SaveChanges();
            }
        }
    }

    public class IdentitySeedData
    {
        private const string adminUser = "Chef";
        private const string adminPassword = "Secret";

        public static async Task EnsurePopulated(UserManager<IdentityUser> userManager)
        {
            /*
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .GetRequiredService<UserManager<IdentityUser>>();
            */
            IdentityUser user = await userManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new IdentityUser("Chef");
                await userManager.CreateAsync(user, adminPassword);
            }
        }
    }
}