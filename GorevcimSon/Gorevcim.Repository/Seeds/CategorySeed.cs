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
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category>builder)
        {
            builder.HasData(new Category { Id = 1, Name = "Ofis Ürünleri" },
                            new Category { Id = 2, Name = "Polen Haşere" },
                            new Category { Id = 3, Name = "İzolasyon" },
                            new Category { Id = 4, Name = "İnşaat" },
                            new Category { Id = 5, Name = "Montaj Asma" },
                            new Category { Id = 6, Name = "Tadilat" },
                            new Category { Id = 7, Name = "Tamir" },
                            new Category { Id = 8, Name = "Maskeleme" },
                            new Category { Id = 9, Name = "Kaydırmaz" },
                            new Category { Id = 10, Name = "İç Cephe Boyalar" },
                            new Category { Id = 11, Name = "Dış Cephe Boyalar" },
                            new Category { Id = 12, Name = "Tinerler" }
                            );
        }
    }
}
