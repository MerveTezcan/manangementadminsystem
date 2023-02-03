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
    internal class ProductWeightSeed : IEntityTypeConfiguration<ProductWeightUnits>
    {
        public void Configure(EntityTypeBuilder<ProductWeightUnits> builder)
        {
            builder.HasData(new ProductWeightUnits
            {
                Id = 1,
                Name = "XXX",
                ShortCode = "X1"
            });

        }
    }
}

           


