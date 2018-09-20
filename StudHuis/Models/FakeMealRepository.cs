using System;
using System.Collections.Generic;
using System.Linq;

namespace StudHuis.Models
{
    public class FakeMealRepository : IMealRepository
    {
        public IQueryable<Meal> Meals => new List<Meal>
        {
            new Meal()
            {
                Id = 0,
                Name = "Spaget",
                Description = "Beste spaget",
                MaxGuests = 200,
                Price = 6.66,
                MealTime = new DateTime(2018, 1, 1)
            },
            new Meal()
            {
                Id = 1,
                Name = "Spaget 2",
                Description = "Beste spaget 2",
                MaxGuests = 200,
                Price = 6.66,
                MealTime = new DateTime(2018, 1, 1)
            }
        }.AsQueryable<Meal>();
    }
}