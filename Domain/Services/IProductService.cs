using System.Threading.Tasks;
using DesignPattern.Domain.Models;
using DesignPattern.Domain.Services.Communication;

namespace DesignPattern.Domain.Services
{
    public interface IProductService
    {
        Task<ProductResponse> SaveAsync(Product product);
    }
}