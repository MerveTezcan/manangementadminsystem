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
    public class ProductImageService : GenericService<ProductImage>, IProductImageService
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;


        public ProductImageService(IGenericRepository<ProductImage> repository, IGenericUnitOfWork unitOfWork, IProductImageRepository productImageRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductImageDto>> GetWebAllProductImage()
        {
            var productImage = await _productImageRepository.GetWebAllProductImageAsync();
            var productImageDtos = _mapper.Map<List<ProductImageDto>>(productImage);
            return productImageDtos;
        }

        public async Task<CustomResponseDto<List<ProductImageDto>>> GetApiAllProductImage()
        {
            var productImage = await _productImageRepository.GetApiAllProductImageAsync();
            var productImageDtos = _mapper.Map<List<ProductImageDto>>(productImage);
            return CustomResponseDto<List<ProductImageDto>>.Success(200, productImageDtos);
        }
        

        public async Task<List<ProductImageDto>> GetWebAllImageAsync()
        {
            var productImage = await _productImageRepository.GetWebAllProductImageAsync();
            var productImageDtos = _mapper.Map<List<ProductImageDto>>(productImage);
            return productImageDtos;
        }


    }

}

