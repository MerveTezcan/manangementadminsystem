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
    public class ProductFeaturesService : GenericService<ProductFeatures>, IProductFeaturesService
    {
        private readonly IProductFeaturesRepository _productFeaturesRepository;
        private readonly IMapper _mapper;


        public ProductFeaturesService(IGenericRepository<ProductFeatures> repository, IGenericUnitOfWork unitOfWork, IProductFeaturesRepository productFeaturesRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productFeaturesRepository = productFeaturesRepository;
            _mapper = mapper;
        }


        public async Task<CustomResponseDto<List<ProductFeaturesDto>>> GetApiAllProductFeatures()
        {
            var productFeatures = await _productFeaturesRepository.GetApiAllProductFeaturesAsync();
            var productFeaturesDtos = _mapper.Map<List<ProductFeaturesDto>>(productFeatures);
            return CustomResponseDto<List<ProductFeaturesDto>>.Success(200, productFeaturesDtos);
        }


        public async Task<List<ProductFeaturesDto>> GetWebAllProductFeatures()
        {
            var productFeatures = await _productFeaturesRepository.GetWebAllProductFeaturesAsync();
            var productFeaturesDtos = _mapper.Map<List<ProductFeaturesDto>>(productFeatures);
            return productFeaturesDtos;
        }

       


    }



}


