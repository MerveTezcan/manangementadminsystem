using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core;
using Gorevcim.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Gorevcim.Repository.AppDbContexts.AppDbContext;
using Gorevcim.Core.Models;
using Gorevcim.Core.Services;

namespace Gorevcim.Repository.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Company>> GetAllCompanyAsync()
        {
            return await _context.Company.Include(x => x.Id).ToListAsync();
        }



        public async Task<List<Company>> GetApiAllCompanyAsync()
        {
            return await _context.Company.Include(x => x.Id).ToListAsync();

        }

        public async Task<List<Company>> GetWebAllCompanyAsync()
        {
            return await _context.Company.ToListAsync();

        }

        public async Task<Company> GetApiCompanyIdBranchOfficeAsync(int companyId)
        {
            return await _context.Company.Include(x => x.BranchOffice).Where(x => x.Id == companyId).SingleOrDefaultAsync();
        }

        public async Task<Company> GetWebCompanyIdBranchOfficeAsync(int companyId)
        {
            return await _context.Company.Include(x => x.BranchOffice).Where(x => x.Id == companyId).SingleOrDefaultAsync();
        }

        public async Task<Company> GetApiCompanyIdCompanyDealerAsync(int companyId)
        {
            return await _context.Company.Include(x => x.CompanyDealer).Where(x => x.Id == companyId).SingleOrDefaultAsync();
        }

        public async Task<Company> GetWebCompanyIdCompanyDealerAsync(int companyId)
        {
            return await _context.Company.Include(x => x.CompanyDealer).Where(x => x.Id == companyId).SingleOrDefaultAsync();
        }
    }
}
