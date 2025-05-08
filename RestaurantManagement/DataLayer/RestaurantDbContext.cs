using System.Data.Entity;
using RestaurantManagement.DAL.Models;

namespace RestaurantManagement.DAL
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("name=cnStr")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffAccount> StaffAccounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
            .HasRequired(a => a.Product)
            .WithMany()
            .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}