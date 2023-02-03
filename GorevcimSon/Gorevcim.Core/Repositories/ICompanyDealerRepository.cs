﻿using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Repositories
{
    public interface ICompanyDealerRepository:IGenericRepository<CompanyDealer>
    {
        Task<List<CompanyDealer>> GetApiAllCompanyDealerAsync();
        Task<List<CompanyDealer>> GetWebAllCompanyDealerAsync();
    }
}
