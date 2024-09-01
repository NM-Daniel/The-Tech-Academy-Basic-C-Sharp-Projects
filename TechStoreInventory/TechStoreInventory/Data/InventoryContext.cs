using Microsoft.EntityFrameworkCore;
using TechStoreInventory.Models;

namespace TechStoreInventory.Data
{
    public class InventoryContext : DbContext //This will allow the application to connect to the database and query the tables
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        public DbSet<Products> Products { get; set; } //The data that we will be interacting with
    }
}
