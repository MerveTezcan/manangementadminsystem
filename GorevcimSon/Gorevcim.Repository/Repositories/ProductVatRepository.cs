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
    public class ProductVatRepository : GenericRepository<ProductVatUnits>, IProductVatUnitsRepository
    {

        public ProductVatRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductVatUnits>> ProductVat()
        {
            return await _context.ProductVatUnits.ToListAsync();
        }

  

        public async Task<List<ProductVatUnits>> GetWebAllProductVatUnitsAsync()
        {
            return await _context.ProductVatUnits.ToListAsync();
        }

        public async Task<List<ProductVatUnits>> GetApiAllProductVatUnitsAsync()
        {
            return await _context.ProductVatUnits.ToListAsync();
        }


        public async Task<List<ProductVatUnits>> GetAllProductVatAsync()
        {
            return await _context.ProductVatUnits.ToListAsync();
        }

        public async Task<List<ProductVatUnits>> GetWebAllProductVatAsync()
        {
            return await _context.ProductVatUnits.ToListAsync();
        }

    }
}
