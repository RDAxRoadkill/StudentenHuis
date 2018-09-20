using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StudHuis.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Provides access to the EFrameworkCore underlying functions
        //Derived from DbContext, used to read & write data
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        //Provides access to the Meals objects in the Database
        public DbSet<Meal> Meals { get; set; }
    }
}