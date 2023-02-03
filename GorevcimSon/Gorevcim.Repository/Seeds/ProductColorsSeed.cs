using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core.Models;



namespace Gorevcim.Repository.Seeds
{
    internal class ProductColorsSeed : IEntityTypeConfiguration<ProductColors>
    {
        public void Configure(EntityTypeBuilder<ProductColors> builder)
        {
            builder.HasData(new ProductColors
            { 
                Id = 1, 
                Name = "Sarı" 
            }

             );
        }
    }
}