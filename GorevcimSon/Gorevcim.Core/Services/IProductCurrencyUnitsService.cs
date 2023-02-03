using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using Gorevcim.Core.Services;

namespace Gorevcim.Core.Services
{
    public interface IProductCurrencyUnitsService : IGenericService<ProductCurrencyUnits>
    {
        public Task<CustomResponseDto<List<ProductCurrencyUnitsDto>>> GetApiAllProductCurrency();
        public Task<List<ProductCurrencyUnitsDto>> GetWebAllProductCurrency();
        public Task<List<ProductCurrencyUnitsDto>> GetWebAllCurrencyAsync();
    }
}
