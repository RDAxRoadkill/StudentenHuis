using System.Linq;

namespace StudHuis.Models
{
    public class IMealRepository
    {
        private IQueryable<Meal> Meals { get;  }
    }
}