using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DesignPattern.Domain.Services;
using DesignPattern.ViewModels;
using DesignPattern.Domain.Models;

namespace DesignPattern.Controllers
{
    [Route("/api/products")]
    [Produces("application/json")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveProductModel resource)
        {
            var product = _mapper.Map<SaveProductModel, Product>(resource);
            var result = await _productService.SaveAsync(product);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            var productResource = _mapper.Map<Product, ProductModel>(result.Resource);
            return Ok(productResource);
        }
    }
}