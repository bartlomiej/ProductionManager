using ProductionManager.Domain.Entities;
using System.Threading.Tasks;

namespace ProductionManager.Application.Contracts.Persistence
{
    public interface IProductPriceRepository : IAsyncRepository<ProductPrice>
    {
        //Task<bool> IsNameAndAuthorAlreadyExist(string title, string author);
    }
}
