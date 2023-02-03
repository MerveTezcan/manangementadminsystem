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
    internal class ProductCurrencySeed : IEntityTypeConfiguration<ProductCurrencyUnits>
    {
        public void Configure(EntityTypeBuilder<ProductCurrencyUnits> builder)
        {
            builder.HasData(new ProductCurrencyUnits
            {
                Id = 1,
                Name = "BBBBb",
                ShortCode = "AAAA",
                Explanation = "dfgvgrfg"

            });

        }
    }
}

           


