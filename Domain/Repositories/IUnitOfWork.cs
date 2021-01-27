using System.Threading.Tasks;

namespace DesignPattern.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}