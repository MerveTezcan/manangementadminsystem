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
    public class ProductCurrencyRepository : GenericRepository<ProductCurrencyUnits>, IProductCurrencyUnitsRepository
    {

        public ProductCurrencyRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<ProductCurrencyUnits>> GetProductCurrency()
        {
            return await _context.ProductCurrencyUnits.ToListAsync();
        }




        public async Task<List<ProductCurrencyUnits>> GetWebAllProductCurrencyUnitsAsync()
        {
            return await _context.ProductCurrencyUnits.ToListAsync();
        }

        public async Task<List<ProductCurrencyUnits>> GetApiAllProductCurrencyUnitsAsync()
        {
            return await _context.ProductCurrencyUnits.ToListAsync();
        }


        public async Task<List<ProductCurrencyUnits>> GetAllProductCurrencyAsync()
        {
            return await _context.ProductCurrencyUnits.ToListAsync();
        }

        public async Task<List<ProductCurrencyUnits>> GetWebAllProductCurrencyAsync()
        {
            return await _context.ProductCurrencyUnits.ToListAsync();
        }

    }
}
