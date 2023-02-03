using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface IProductProjectsService : IGenericService<ProductProjects>
    {
        public Task<CustomResponseDto<List<ProductProjectsDto>>> GetApiAllProductProjects();
        public Task<List<ProductProjectsDto>> GetWebAllProductProjects();
        public Task<List<ProductProjectsDto>> GetWebAllProjectAsync();
       
    }
}
