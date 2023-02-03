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
    public class ProductImageRepository : GenericRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductImage>> GetProductImage()
        {
            return await _context.ProductImages.ToListAsync();
        }


        public async Task<List<ProductImage>> GetWebAlllProductImageAsync()
        {
            return await _context.ProductImages.ToListAsync();
        }


       

        public async Task<List<ProductImage>> GetApiAllProductImageAsync()
        {
            return await _context.ProductImages.ToListAsync();
        }


        public async Task<List<ProductImage>> GetAllProductImageAsync()
        {
            return await _context.ProductImages.ToListAsync();
        }

        public async Task<List<ProductImage>> GetWebAllProductImageAsync()
        {
            return await _context.ProductImages.ToListAsync();
        }

    }
}
