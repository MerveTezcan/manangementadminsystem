using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface IBranchOfficeRepository:IGenericRepository<BranchOffice>
    {
        Task<List<BranchOffice>> GetApiAllBranchOfficeAsync();
        Task<List<BranchOffice>> GetWebAllBranchOfficeAsync();

    }
}
