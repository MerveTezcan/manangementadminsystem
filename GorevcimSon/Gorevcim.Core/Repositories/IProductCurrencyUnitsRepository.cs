using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IProductCurrencyUnitsRepository : IGenericRepository<ProductCurrencyUnits>
    {
        Task<List<ProductCurrencyUnits>> GetApiAllProductCurrencyUnitsAsync();
        Task<List<ProductCurrencyUnits>> GetWebAllProductCurrencyUnitsAsync();
    }
}
