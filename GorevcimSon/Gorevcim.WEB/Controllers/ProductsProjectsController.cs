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
    public class ProductsProjectsController : Controller
    {
        private readonly IProductProjectsService _productProjectsService;
        private readonly IMapper _mapper;

        public ProductsProjectsController(IProductProjectsService productProjectsService, IMapper mapper)
        {
            _productProjectsService = productProjectsService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var productProjects = await _productProjectsService.GetWebAllProductProjects();
            dynamic mymodel = new ExpandoObject();
            mymodel._productProjects = productProjects;
            mymodel.activeProductProjectCount = productProjects.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductProjectCount = productProjects.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }



        public async Task<IActionResult> Save()
        {
            var productProjects = await _productProjectsService.GetAllAsync(); //    var productsColor = await _productColorsService.GetAllAsync();
            var ProductsProjectsDto = _mapper.Map<List<ProductProjectsDto>>(productProjects.ToList());
            ViewBag.productProject = new SelectList(ProductsProjectsDto, "Id", "Name");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductProjectsDto productsProjectsDto)
        {
            if (ModelState.IsValid)
            {
                await _productProjectsService.AddAsync(_mapper.Map<ProductProjects>(productsProjectsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
            var productProjects = await _productProjectsService.GetAllAsync();
            var ProductsProjectsDto = _mapper.Map<List<ProductProjectsDto>>(productProjects.ToList());
            ViewBag.productProject = new SelectList(ProductsProjectsDto, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productProjects = await _productProjectsService.GetByIdAsync(Id);
            var productProject = await _productProjectsService.GetAllAsync();
            var ProductsProjectsDto = _mapper.Map<List<ProductProjectsDto>>(productProject.ToList());
            ViewBag.productProject = new SelectList(ProductsProjectsDto, "Id", "Name", productProjects);
            return View(_mapper.Map<ProductProjectsDto>(productProjects));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductProjectsDto productsProjectsDto)
        {
            if (ModelState.IsValid)
            {
                await _productProjectsService.UpdateAsync(_mapper.Map<ProductProjects>(productsProjectsDto));
                TempData.Add("Info", "Ürün başarıyla güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Info", "Hata Oluştu. ProductsController|Update|79");
            var productProject = await _productProjectsService.GetAllAsync();
            var ProductsProjectsDto = _mapper.Map<List<ProductProjectsDto>>(productProject.ToList());
            ViewBag.productProject = new SelectList(ProductsProjectsDto, "Id", "Name", productsProjectsDto);
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var productProject = await _productProjectsService.GetByIdAsync(Id);
            await _productProjectsService.RemoveAsync(productProject);
            TempData.Add("Info", "Ürün başarıyla silinmiştir.");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var productProject = await _productProjectsService.GetByIdAsync(Id);
            var productProjects = await _productProjectsService.GetAllAsync();
            var ProductsProjectsDto = _mapper.Map<List<ProductProjectsDto>>(productProjects.ToList());
            ViewBag.productProject = new SelectList(ProductsProjectsDto, "Id", "Name", productProject);
            return View(_mapper.Map<ProductProjectsDto>(productProject));
        }





    }
}