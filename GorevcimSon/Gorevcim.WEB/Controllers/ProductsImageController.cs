using Microsoft.AspNetCore.Mvc;
using Gorevcim.Core.Services;
using Gorevcim.Core.DTOs;
using Gorevcim.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using Gorevcim.Core.Models;
using Gorevcim.Service.Services;
using System.Web;
using System.IO;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using static System.Net.Mime.MediaTypeNames;
using System.Text;





namespace Gorevcim.WEB.Controllers
{
    public class ProductsImageController : Controller
    {
        private readonly IProductImageService _productImageService;
        private readonly IMapper _mapper;

        private readonly IHostingEnvironment _environment;

        public ProductsImageController(IProductImageService productImageService, IMapper mapper,IHostingEnvironment environment)
        {
            _productImageService = productImageService;
            _mapper = mapper;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var productImage = await _productImageService.GetWebAllProductImage();
            dynamic mymodel = new ExpandoObject();
            mymodel._productImage = productImage;
            mymodel.activeProductImageCount = productImage.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductImageCount = productImage.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }



        public async Task<IActionResult> Save()
        {
            var productImage = await _productImageService.GetAllAsync(); //    var productsColor = await _productColorsService.GetAllAsync();
            var ProductImageDto = _mapper.Map<List<ProductImageDto>>(productImage.ToList());
            ViewBag.productImage = new SelectList(ProductImageDto, "Id", "Name");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductImageDto productImageDto, IFormFile file,string base64String)
        {
            var folderPath = Path.Combine(_environment.WebRootPath, "ImagesUploads");
            var filePath = Path.Combine(folderPath, file.FileName);

            DateTime date = DateTime.Now;
            string date_str = date.ToString("dd-MM-yyyy-HH-mm--ss");
            var _imagesName = date_str + file.FileName;




            if (file.Length >0)
            {
                using (var stream = new FileStream( filePath,FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                byte[] byes_array = System.IO.File.ReadAllBytes(filePath);
                base64String = Convert.ToBase64String(byes_array);

                var _imagesPath = filePath;
                var _imagesBase64 = base64String;



                productImageDto.LogoBase64Content = _imagesBase64;  
                productImageDto.ImageName = _imagesName;
                productImageDto.FilePath = _imagesPath;

                await _productImageService.AddAsync(_mapper.Map<ProductImage>(productImageDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }


            else
            {
                TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
                return View();
            }
           
                       
        }

    }
}