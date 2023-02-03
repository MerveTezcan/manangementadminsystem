
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core.Models;

namespace Gorevcim.Repository.AppDbContexts.AppDbContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) //constructor yaptık. 
        {   
        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductBrands> ProductBrands { get; set; }

        public DbSet<ProductColors> ProductColors { get; set; }

        public DbSet<ProductCurrencyUnits> ProductCurrencyUnits { get; set; }

        public DbSet<ProductFeatures> ProductFeatures { get; set; }

        public DbSet<ProductMeasurementUnits> ProductMeasurementUnits { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<ProductWeightUnits> ProductWeightUnits { get; set; }

        public DbSet<ProductVatUnits> ProductVatUnits { get; set; }

        public DbSet<ProductProjects> ProductProjects { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<CompanyDealer> CompanyDealer { get; set; }

        public DbSet<BranchOffice> BranchOffice { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
