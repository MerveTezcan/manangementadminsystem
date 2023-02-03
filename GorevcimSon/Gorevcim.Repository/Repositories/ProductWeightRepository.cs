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
    public class ProductWeightRepository : GenericRepository<ProductWeightUnits>, IProductWeightUnitsRepository
    {

        public ProductWeightRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductWeightUnits>> ProductWeight()
        {
            return await _context.ProductWeightUnits.ToListAsync();
        }

  

        public async Task<List<ProductWeightUnits>> GetWebAllProductWeightUnitsAsync()
        {
            return await _context.ProductWeightUnits.ToListAsync();
        }

        public async Task<List<ProductWeightUnits>> GetApiAllProductWeightUnitsAsync()
        {
            return await _context.ProductWeightUnits.ToListAsync();
        }


        public async Task<List<ProductWeightUnits>> GetAllProductWeightAsync()
        {
            return await _context.ProductWeightUnits.ToListAsync();
        }

        public async Task<List<ProductWeightUnits>> GetWebAllProductWeightAsync()
        {
            return await _context.ProductWeightUnits.ToListAsync();
        }

    }
}
