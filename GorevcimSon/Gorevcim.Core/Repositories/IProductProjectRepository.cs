using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IProductProjectRepository :IGenericRepository<ProductProjects>
    {
        Task<List<ProductProjects>> GetApiAllProductProjectAsync();
        Task<List<ProductProjects>> GetWebAllProductProjectAsync();
    }
    
    
}

