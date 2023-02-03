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
    public class ProductCurrencyService : GenericService<ProductCurrencyUnits>, IProductCurrencyUnitsService
    {
        private readonly IProductCurrencyUnitsRepository _productCurrencyUnitsRepository;
        private readonly IMapper _mapper;

        public ProductCurrencyService(IGenericRepository<ProductCurrencyUnits> repository, IGenericUnitOfWork unitOfWork, IProductCurrencyUnitsRepository productCurrencyUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productCurrencyUnitsRepository = productCurrencyUnitsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductCurrencyUnitsDto>> GetWebAllProductCurrency()
        {
            var productCurrency = await _productCurrencyUnitsRepository.GetWebAllProductCurrencyUnitsAsync();
            var productCurrencyDtos = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrency);
            return productCurrencyDtos;
        }


        public async Task<CustomResponseDto<List<ProductCurrencyUnitsDto>>> GetApiAllProductCurrency()
        {
            var productCurrency = await _productCurrencyUnitsRepository.GetApiAllProductCurrencyUnitsAsync();
            var productCurrencyDtos = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrency);
            return CustomResponseDto<List<ProductCurrencyUnitsDto>>.Success(200, productCurrencyDtos);
        }


        public async Task<List<ProductCurrencyUnitsDto>> GetWebAllCurrencyAsync()
        {
            var productCurrency = await _productCurrencyUnitsRepository.GetWebAllProductCurrencyUnitsAsync();
            var productCurrencyDtos = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrency);
            return productCurrencyDtos;
        }


    }

}

