using System.Threading.Tasks;
using DesignPattern.Domain.Models;

namespace DesignPattern.Domain.Repositories
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product> FindByIdAsync(int id);
    }
}