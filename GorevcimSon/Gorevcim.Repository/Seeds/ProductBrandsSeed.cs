using Gorevcim.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Seeds
{
    internal class ProductBrandsSeed : IEntityTypeConfiguration<ProductBrands>
    {
        public void Configure(EntityTypeBuilder<ProductBrands> builder)
        {
            builder.HasData(new ProductBrands
            {
                Id = 1,
                BrandsName = "BBBBb",
                BrandsWebUrl = "AAAA",
                Explanation = "dfgvgrfg",
                ShortCode= "sddsad"
            });

        }
    }
}

           


