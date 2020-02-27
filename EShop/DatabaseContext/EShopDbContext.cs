using EShop.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.DatabaseContext
{
     public class EShopDbContext : DbContext
    {
        private const string connectionString = "Server = MIZAN\\MIZANSQL; Database = EshopDB; Integrated Security = true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(c => c.Code);
            modelBuilder.Entity<Customer>().ToTable("Clients");

            modelBuilder.Entity<Product>().HasQueryFilter(c => c.IsDeleted == false);
            
            
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Shop> Shops { get; set; }





    }
}
