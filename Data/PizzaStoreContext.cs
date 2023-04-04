using Microsoft.EntityFrameworkCore;

namespace MyFirstBlazorApp.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Specials { get; set; }
    }
}