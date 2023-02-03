using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IProductWeightUnitsRepository : IGenericRepository<ProductWeightUnits>
    {
        Task<List<ProductWeightUnits>> GetApiAllProductWeightUnitsAsync();
        Task<List<ProductWeightUnits>> GetWebAllProductWeightUnitsAsync();

    }
}
