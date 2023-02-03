using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;

namespace Gorevcim.Core.Services
{
    public interface IProductImageService :IGenericService<ProductImage>
    {
        public Task<CustomResponseDto<List<ProductImageDto>>> GetApiAllProductImage();
        public Task<List<ProductImageDto>> GetWebAllProductImage();
        public Task<List<ProductImageDto>> GetWebAllImageAsync();

    }
}
