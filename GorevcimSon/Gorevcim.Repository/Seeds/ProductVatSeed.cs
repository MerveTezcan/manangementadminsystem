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
    internal class ProductVatSeed : IEntityTypeConfiguration<ProductVatUnits>
    {
        public void Configure(EntityTypeBuilder<ProductVatUnits> builder)
        {
            builder.HasData(new ProductVatUnits
            {
                Id = 1,
                Name = "XXX",
                Code = "1",
              

            });

        }
    }
}

           


