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
    public class ProductVatService : GenericService<ProductVatUnits>, IProductVatUnitsService
    {
        private readonly IProductVatUnitsRepository _productVatUnitsRepository;
  
        private readonly IMapper _mapper;

        public ProductVatService(IGenericRepository<ProductVatUnits> repository, IGenericUnitOfWork unitOfWork, IProductVatUnitsRepository productVatUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productVatUnitsRepository = productVatUnitsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductVatUnitsDto>> GetWebAllProductVatUnits()
        {
            var productVat = await _productVatUnitsRepository.GetWebAllProductVatUnitsAsync();
            var productVatDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVat);
            return productVatDtos;
        }



        public async Task<CustomResponseDto<List<ProductVatUnitsDto>>> GetApiAllProductVatUnits()
        {
            var productVat = await _productVatUnitsRepository.GetApiAllProductVatUnitsAsync();
            var productVatDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVat);
            return CustomResponseDto<List<ProductVatUnitsDto>>.Success(200, productVatDtos);
        }


        public async Task<List<ProductVatUnitsDto>> GetWebAllVatAsync()
        {
            var productVat = await _productVatUnitsRepository.GetWebAllProductVatUnitsAsync();
            var productVatDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVat);
            return productVatDtos;
        }




    }

}

