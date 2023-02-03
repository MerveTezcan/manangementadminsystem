using Gorevcim.Repository.AppDbContexts.AppDbContext;
using Gorevcim.Core.Models;
using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class ProductBrandsRepository : GenericRepository<ProductBrands>, IProductBrandsRepository
    {
        public ProductBrandsRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductBrands>> GetProductBrands()
        {
            return await _context.ProductBrands.ToListAsync();
        }


        public async Task<List<ProductBrands>> GetWebAllProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }


        public async Task<List<ProductBrands>> GetApiAllProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }


        public async Task<List<ProductBrands>> GetAllProductBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }

        public async Task<List<ProductBrands>> GetWebAllProductBrandAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }

    }
}
