﻿using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface IBranchOfficeService : IGenericService<BranchOffice>
    {
        public Task<CustomResponseDto<List<BranchOfficeDto>>> GetApiAllBranchOffice();
        public Task<List<BranchOfficeDto>> GetWebAllBranchOffice();
        public Task<List<BranchOfficeDto>> GetWebAllBranchOfficeAsync();
    }
}
