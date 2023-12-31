﻿using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
    public class ECommerceContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=E_Commerce;Trusted_Connection=true;TrustServerCertificate=True;Encrypt=False;");
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<FavouriteList> FavouriteList { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CreditCard>()
                .HasKey(c => c.CardID);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FavouriteList>()
                .HasKey(c => c.FavouriteID);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
               .HasKey(c => c.CategoryID);
            base.OnModelCreating(modelBuilder);

        }
    }
}
