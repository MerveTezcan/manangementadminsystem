using Gorevcim.Core;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Repositories;
using Gorevcim.Core.Services;
using Gorevcim.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Gorevcim.Core.Models;
using Gorevcim.Repository.UnitOfWorks;
using System.Reflection.Metadata.Ecma335;
using Gorevcim.Repository.Repositories;

namespace Gorevcim.Service.Services
{
    public class ProductWeightService : GenericService<ProductWeightUnits>, IProductWeightUnitsService
    {
        private readonly IProductWeightUnitsRepository _productWeightUnitsRepository;
        private readonly IMapper _mapper;

        public ProductWeightService(IGenericRepository<ProductWeightUnits> repository, IGenericUnitOfWork unitOfWork, IProductWeightUnitsRepository productWeightUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productWeightUnitsRepository = productWeightUnitsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductWeightUnitsDto>> GetWebAllProductWeightUnits()
        {
            var productWeight = await _productWeightUnitsRepository.GetWebAllProductWeightUnitsAsync();
            var productWeightDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight);
            return productWeightDtos;
        }



        public async Task<CustomResponseDto<List<ProductWeightUnitsDto>>> GetApiAllProductWeightUnits()
        {
            var productWeight = await _productWeightUnitsRepository.GetApiAllProductWeightUnitsAsync();
            var productWeightDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight);
            return CustomResponseDto<List<ProductWeightUnitsDto>>.Success(200, productWeightDtos);
        }


        public async Task<List<ProductWeightUnitsDto>> GetWebAllWeightAsync()
        {
            var productWeight = await _productWeightUnitsRepository.GetWebAllProductWeightUnitsAsync();
            var productWeightDtos = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight);
            return productWeightDtos;
        }




    }

}

