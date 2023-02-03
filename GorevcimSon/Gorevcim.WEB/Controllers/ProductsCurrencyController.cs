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
    public class ProductsCurrencyController : Controller
    {
        private readonly IProductCurrencyUnitsService _productCurrencyUnitsService;
        private readonly IMapper _mapper;

        public ProductsCurrencyController(IProductCurrencyUnitsService productCurrencyUnitsService, IMapper mapper)
        {
            _productCurrencyUnitsService = productCurrencyUnitsService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var productCurrency = await _productCurrencyUnitsService.GetWebAllProductCurrency();
            dynamic mymodel = new ExpandoObject();
            mymodel._productCurrency = productCurrency;
            mymodel.activeProductCurrencyCount = productCurrency.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductCurrencyCount = productCurrency.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }



        public async Task<IActionResult> Save()
        {
            var productCurrency = await _productCurrencyUnitsService.GetAllAsync(); //    var productsColor = await _productColorsService.GetAllAsync();
            var productCurrencyDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrency.ToList());
            ViewBag.productCurrency = new SelectList(productCurrencyDto, "Id", "Name");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductCurrencyUnitsDto productCurrencyUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productCurrencyUnitsService.AddAsync(_mapper.Map<ProductCurrencyUnits>(productCurrencyUnitsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
            var productCurrency = await _productCurrencyUnitsService.GetAllAsync();
            var productCurrencyDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrency.ToList());
            ViewBag.productCurrency = new SelectList(productCurrencyDto, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productCurrency = await _productCurrencyUnitsService.GetByIdAsync(Id);
            var ProductCurrency = await _productCurrencyUnitsService.GetAllAsync();
            var productCurrencyDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(ProductCurrency.ToList());
            ViewBag.productCurrency = new SelectList(productCurrencyDto, "Id", "Name", productCurrency);
            return View(_mapper.Map<ProductCurrencyUnitsDto>(productCurrency));
        }



        [HttpPost]
        public async Task<IActionResult> Update(ProductCurrencyUnitsDto productCurrencyUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productCurrencyUnitsService.UpdateAsync(_mapper.Map<ProductCurrencyUnits>(productCurrencyUnitsDto));
                TempData.Add("Info", "Ürün başarıyla güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Info", "Hata Oluştu. ProductsController|Update|79");
            var productCurrency = await _productCurrencyUnitsService.GetAllAsync();
            var productCurrencyDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(productCurrency.ToList());
            ViewBag.productCurrency = new SelectList(productCurrencyDto, "Id", "Name", productCurrencyDto);
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var productCurrency = await _productCurrencyUnitsService.GetByIdAsync(Id);
            await _productCurrencyUnitsService.RemoveAsync(productCurrency);
            TempData.Add("Info", "Ürün başarıyla silinmiştir.");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var productCurrency = await _productCurrencyUnitsService.GetByIdAsync(Id);
            var ProductCurrency = await _productCurrencyUnitsService.GetAllAsync();
            var productCurrencyDto = _mapper.Map<List<ProductCurrencyUnitsDto>>(ProductCurrency.ToList());
            ViewBag.productCurrency = new SelectList(productCurrencyDto, "Id", "Name", productCurrency);
            return View(_mapper.Map<ProductCurrencyUnitsDto>(productCurrency));
        }





    }
}