using Gorevcim.Core.Models;
using Gorevcim.Core.Repositories;
using Gorevcim.Repository.AppDbContexts.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Repository.Repositories
{
    public class BranchOfficeRepository : GenericRepository<BranchOffice>, IBranchOfficeRepository
    {
        public BranchOfficeRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<BranchOffice>> GetApiAllBranchOfficeAsync()
        {
            return await _context.BranchOffice.ToListAsync();
        }

        public async Task<List<BranchOffice>> GetWebAllBranchOfficeAsync()
        {
            return await _context.BranchOffice.ToListAsync();
        }
    }
}
