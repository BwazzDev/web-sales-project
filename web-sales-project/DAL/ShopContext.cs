using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using web_sales_project.Models;

namespace web_sales_project.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SalesItem> SalesItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}