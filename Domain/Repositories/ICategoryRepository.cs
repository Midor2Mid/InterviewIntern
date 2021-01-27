using System.Threading.Tasks;
using DesignPattern.Domain.Models;

namespace DesignPattern.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
    }
}