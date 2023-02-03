﻿using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface ICompanyDealerService : IGenericService<CompanyDealer>
    {
        public Task<CustomResponseDto<List<CompanyDealerDto>>> GetApiAllCompanyDealer();
        public Task<List<CompanyDealerDto>> GetWebAllCompanyDealer();
        public Task<List<CompanyDealerDto>> GetWebAllCompanyDealerAsync();
    }
}
