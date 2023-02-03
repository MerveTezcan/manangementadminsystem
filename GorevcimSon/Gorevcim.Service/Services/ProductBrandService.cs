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
    public class ProductBrandService : GenericService<ProductBrands>, IProductBrandsService
    {
        private readonly IProductBrandsRepository _productBrandsRepository;
        private readonly IMapper _mapper;


        public ProductBrandService(IGenericRepository<ProductBrands> repository, IGenericUnitOfWork unitOfWork, IProductBrandsRepository productBrandsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productBrandsRepository = productBrandsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductBrandsDto>> GetWebAllProductBrands()
        {
            var productBrands = await _productBrandsRepository.GetWebAllProductBrandsAsync();
            var productBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
            return productBrandsDtos;
        }

        public async Task<CustomResponseDto<List<ProductBrandsDto>>> GetApiAllProductBrands()
        {
            var productBrands = await _productBrandsRepository.GetApiAllProductBrandsAsync();
            var productBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
            return CustomResponseDto<List<ProductBrandsDto>>.Success(200, productBrandsDtos);
        }
        

        public async Task<List<ProductBrandsDto>> GetWebAllBrandsAsync()
        {
            var productBrands = await _productBrandsRepository.GetWebAllProductBrandsAsync();
            var productBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
            return productBrandsDtos;
        }


    }

}

