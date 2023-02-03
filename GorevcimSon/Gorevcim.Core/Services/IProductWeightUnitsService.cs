using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface IProductWeightUnitsService : IGenericService<ProductWeightUnits>
    {
        public Task<CustomResponseDto<List<ProductWeightUnitsDto>>> GetApiAllProductWeightUnits();
        public Task<List<ProductWeightUnitsDto>> GetWebAllProductWeightUnits();
        public Task<List<ProductWeightUnitsDto>> GetWebAllWeightAsync();

    }
}
