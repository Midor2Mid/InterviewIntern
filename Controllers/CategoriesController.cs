using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DesignPattern.Domain.Services;
using DesignPattern.ViewModels;
using DesignPattern.Domain.Models;

namespace DesignPattern.Controllers
{
    [Route("/api/categories")]
    [Produces("application/json")]
    [ApiController]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryModel resource)
        {
            var category = _mapper.Map<SaveCategoryModel, Category>(resource);
            var result = await _categoryService.SaveAsync(category);

            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            var categoryResource = _mapper.Map<Category, CategoryModel>(result.Resource);
            return Ok(categoryResource);
        }
    }
}