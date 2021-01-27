using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesignPattern.Domain.Models;
using DesignPattern.Domain.Repositories;
using DesignPattern.Persistence.Contexts;

namespace DesignPattern.Persistence.Repositories
{
	public class ProductRepository : BaseRepository, IProductRepository
	{
		public ProductRepository(AppDbContext context) : base(context) { }

		public async Task<Product> FindByIdAsync(int id)
		{
			return await _context.Products
								 .Include(p => p.Category)
								 .FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task AddAsync(Product product)
		{
			await _context.Products.AddAsync(product);
		}
	}
}