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
    internal class ProductMeasurementSeed : IEntityTypeConfiguration<ProductMeasurementUnits>
    {
        public void Configure(EntityTypeBuilder<ProductMeasurementUnits> builder)
        {
            builder.HasData(new ProductMeasurementUnits
            {
                Id = 1,
                Name = "XXX",
                ShortCode = "xx"
            });

        }
    }
}

           


