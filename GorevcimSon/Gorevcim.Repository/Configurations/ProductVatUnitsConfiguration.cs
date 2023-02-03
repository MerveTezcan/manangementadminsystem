using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core.Models;

namespace Gorevcim.Repository.Configurations
{
    internal class ProductVatUnitsConfiguration : IEntityTypeConfiguration<ProductVatUnits>
    { 
        public void Configure(EntityTypeBuilder<ProductVatUnits>builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(1000);
            builder.Property(x => x.Code).IsRequired(false).HasMaxLength(1000);
        }
    }
}

