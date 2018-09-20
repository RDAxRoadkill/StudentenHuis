using System.Collections.Generic;
using System.Linq;

namespace StudHuis.Models
{
    public class EFMealRepository : IMealRepository
    {
        private ApplicationDbContext context;

        public EFMealRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Meal> Meals => context.Meals;
    }
}