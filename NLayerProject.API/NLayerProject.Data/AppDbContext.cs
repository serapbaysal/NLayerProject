using Microsoft.EntityFrameworkCore;
using NLayerProject.Core.Models;
using NLayerProject.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories
        {
            get;
            set;

        }
        public DbSet<Product> Products
        {
            get;
            set;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //configuration dosyaları burada da yazılabilir
            // modelBuilder.Entity<Product>().Property(x=>x.Id)


            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.ApplyConfiguration(new ProductSeed( new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));


        }
    }
}
