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
    public class CompanyDealerRepository : GenericRepository<CompanyDealer>, ICompanyDealerRepository
    {
        public CompanyDealerRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<CompanyDealer>> GetApiAllCompanyDealerAsync()
        {
            return await _context.CompanyDealer.ToListAsync();
        }

        public async Task<List<CompanyDealer>> GetWebAllCompanyDealerAsync()
        {
            return await _context.CompanyDealer.ToListAsync();
        }
    }
}
