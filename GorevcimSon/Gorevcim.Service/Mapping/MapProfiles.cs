using AutoMapper;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Service.Mapping
{
    public class MapProfiles:Profile
    {
        public MapProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Products, ProductDto>().ReverseMap();
            CreateMap<ProductFeatures, ProductFeaturesDto>().ReverseMap();
            CreateMap<ProductColors, ProductColorsDto>().ReverseMap();
            CreateMap<ProductCurrencyUnits, ProductCurrencyUnitsDto>().ReverseMap();
            CreateMap<ProductMeasurementUnits, ProductMeasurementUnitsDto>().ReverseMap();
            CreateMap<ProductProjects, ProductProjectsDto>().ReverseMap();
            CreateMap<ProductVatUnits, ProductVatUnitsDto>().ReverseMap();
            CreateMap<ProductWeightUnits, ProductWeightUnitsDto>().ReverseMap();
            CreateMap<ProductBrands, ProductBrandsDto>().ReverseMap();
            CreateMap<Products, ProductCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryProductDto>().ReverseMap();
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<CompanyDealer, CompanyDealerDto>().ReverseMap();
            CreateMap<BranchOffice, BranchOfficeDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();


        }
    }
}
