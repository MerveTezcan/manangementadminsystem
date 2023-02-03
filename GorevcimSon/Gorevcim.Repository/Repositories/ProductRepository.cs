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
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Products>> GetProductsCategorys()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }


        public async Task<List<Products>> GetWebAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }




        public async Task<List<Products>> GetApiAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }



        public async Task<List<Products>> GetAllProductsCategorysAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }

        public async Task<List<Products>> GetWebAllProductsAsync()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();

        }


    }
}
