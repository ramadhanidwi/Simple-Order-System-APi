using Microsoft.EntityFrameworkCore;
using Simple_Order_System_APi.Models;
using System.Data;

namespace Simple_Order_System_APi.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) 
        { 
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductLine> ProductLines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<Role> Roles { get; set; }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                },
                new Role
                {
                    Id = 2,
                    Name = "User",
                });

            // Membuat atribute menjadi unique
            modelBuilder.Entity<Employee>().HasIndex(e => new
            {
                e.Email
            }).IsUnique();

            // Relasi one Employee ke one Account 
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Account)
                .WithOne(a => a.Employee)
                .HasForeignKey<Account>(fk => fk.EmployeeId);

            // Relasi ke many employee ke one manager
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.ReportTo)
                .WithMany(e => e.Employees)
                .HasForeignKey(fk => fk.ReportsTo)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
