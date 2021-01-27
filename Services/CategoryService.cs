using System;
using System.Threading.Tasks;
using DesignPattern.Domain.Models;
using DesignPattern.Domain.Repositories;
using DesignPattern.Domain.Services;
using DesignPattern.Domain.Services.Communication;

namespace DesignPattern.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CategoryResponse> SaveAsync(Category category)
        {
            try
            {
                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new CategoryResponse(category);
            }
            catch (Exception ex)
            {
                return new CategoryResponse($"{ex.Message}");
            }
        }
    }
}
