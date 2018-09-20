using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace StudHuis.Models
{
    public class SeedData
    {
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
}