using System.Threading.Tasks;
using DesignPattern.Domain.Models;
using DesignPattern.Domain.Services.Communication;

namespace DesignPattern.Domain.Services
{
    public interface ICategoryService
    {
         Task<CategoryResponse> SaveAsync(Category category);
    }
}