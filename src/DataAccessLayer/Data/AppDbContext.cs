using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Categories;
using DataAccessLayer.Entities.Customers;
using DataAccessLayer.Entities.Persons;
using DataAccessLayer.Entities.Products;
using DataAccessLayer.Entities.Seling;
using DataAccessLayer.Entities.Transfers;
using DataAccessLayer.Entities.Users;
using DataAccessLayer.Entities.Warehouses;
using DataAccessLayer.Entities.Werhouses;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                    : base(options)
        {
            //Database.EnsureCreated();
            //Database.Migrate();
        }

        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<WarehouseItem> WarehousesItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanPayment> LoanPayments { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<TransferWarehouseItem> TransferWarehouseItems { get; set; }
        public DbSet<VerificationCode> VerificationCodes { get; set; }
    }
}
