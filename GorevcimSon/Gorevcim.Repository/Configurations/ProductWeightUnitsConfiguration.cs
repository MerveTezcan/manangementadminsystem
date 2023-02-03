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
    internal class ProductWeightUnitsConfiguration : IEntityTypeConfiguration<ProductWeightUnits>
    { 
        public void Configure (EntityTypeBuilder<ProductWeightUnits> builder)
            {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.ShortCode).IsRequired(false).HasMaxLength(250);
            builder.Property(x => x.Explanation).IsRequired(false).HasMaxLength(500);
        }
    }
}
