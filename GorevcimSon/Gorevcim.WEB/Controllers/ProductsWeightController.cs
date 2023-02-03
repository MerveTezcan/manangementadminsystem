using Microsoft.AspNetCore.Mvc;
using Gorevcim.Core.Services;
using Gorevcim.Core.DTOs;
using Gorevcim.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using Gorevcim.Core.Models;

namespace Gorevcim.WEB.Controllers
{
    public class ProductsWeightController : Controller
    {
        private readonly IProductWeightUnitsService _productWeightUnitsService;
        private readonly IMapper _mapper;

        public ProductsWeightController(IProductWeightUnitsService productWeightUnitsService, IMapper mapper)
        {
            _productWeightUnitsService = productWeightUnitsService;
            _mapper = mapper;
        } 

        public async Task<IActionResult> Index()
        {
            var productWeight = await _productWeightUnitsService.GetWebAllProductWeightUnits();
            dynamic mymodel = new ExpandoObject();
            mymodel._productWeight = productWeight;
            mymodel.activeProductWeightCount = productWeight.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductWeightCount = productWeight.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }



        public async Task<IActionResult> Save()
        {
            var productWeight = await _productWeightUnitsService.GetAllAsync(); //    var productsColor = await _productColorsService.GetAllAsync();
            var productWeightDto = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight.ToList());
            ViewBag.productWeight = new SelectList(productWeightDto, "Id", "Name");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductWeightUnitsDto productWeightUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productWeightUnitsService.AddAsync(_mapper.Map<ProductWeightUnits>(productWeightUnitsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
            var productWeight = await _productWeightUnitsService.GetAllAsync();
            var productWeightDto = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight.ToList());
            ViewBag.productWeight = new SelectList(productWeightDto, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productWeight = await _productWeightUnitsService.GetByIdAsync(Id);
            var ProductWeight = await _productWeightUnitsService.GetAllAsync();
            var productWightDto = _mapper.Map<List<ProductWeightUnitsDto>>(ProductWeight.ToList());
            ViewBag.productWeight = new SelectList(productWightDto, "Id", "Name", productWeight);
            return View(_mapper.Map<ProductWeightUnitsDto>(productWeight));
        }



        [HttpPost]
        public async Task<IActionResult> Update(ProductWeightUnitsDto productWeightUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productWeightUnitsService.UpdateAsync(_mapper.Map<ProductWeightUnits>(productWeightUnitsDto));
                TempData.Add("Info", "Ürün başarıyla güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Info", "Hata Oluştu. ProductsController|Update|79");
            var productWeight = await _productWeightUnitsService.GetAllAsync();
            var productWeightDto = _mapper.Map<List<ProductWeightUnitsDto>>(productWeight.ToList());
            ViewBag.productWeight = new SelectList(productWeightDto, "Id", "Name", productWeightDto);
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var productWeight = await _productWeightUnitsService.GetByIdAsync(Id);
            await _productWeightUnitsService.RemoveAsync(productWeight);
            TempData.Add("Info", "Ürün başarıyla silinmiştir.");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var productWeight = await _productWeightUnitsService.GetByIdAsync(Id);
            var ProductWeight = await _productWeightUnitsService.GetAllAsync();
            var productWightDto = _mapper.Map<List<ProductWeightUnitsDto>>(ProductWeight.ToList());
            ViewBag.productWeight = new SelectList(productWightDto, "Id", "Name", productWeight);
            return View(_mapper.Map<ProductWeightUnitsDto>(productWeight));
        }





    }
}