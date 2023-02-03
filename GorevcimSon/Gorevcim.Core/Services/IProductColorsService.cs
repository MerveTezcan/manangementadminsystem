using Gorevcim.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core.Models;
using Gorevcim.Core.Services;

namespace Gorevcim.Core.Services
{
    public interface IProductColorsService:IGenericService<ProductColors>
    { 
        public Task<CustomResponseDto<List<ProductColorsDto>>> GetApiAllProductColors();
        public Task<List<ProductColorsDto>> GetWebAllProductColors();
        public Task<List<ProductColorsDto>> GetWebAllColorsAsync();
    }
}
