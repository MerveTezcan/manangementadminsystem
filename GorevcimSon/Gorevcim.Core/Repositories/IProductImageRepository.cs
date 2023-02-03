using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IProductImageRepository :IGenericRepository<ProductImage>
    {
        Task<List<ProductImage>> GetApiAllProductImageAsync();
        Task<List<ProductImage>> GetWebAllProductImageAsync();
    }
}
