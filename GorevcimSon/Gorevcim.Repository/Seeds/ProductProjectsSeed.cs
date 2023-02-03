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
    internal class ProductProductsSeed : IEntityTypeConfiguration<ProductProjects>
    {
        public void Configure(EntityTypeBuilder<ProductProjects> builder)
        {
            builder.HasData(new ProductProjects
            {
                Id = 1,
                Name = "Aaa"
            });
        }
    }
}
