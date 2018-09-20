using System.Collections.Generic;
using System.Linq;

namespace StudHuis.Models
{
    public interface IMealRepository
    {
        IQueryable<Meal> Meals { get; }
        //public IEnumerable<Meal> Meals { get; }
}
}