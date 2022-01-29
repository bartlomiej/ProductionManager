using ProductionManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.Application.Contracts.Persistence
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
        //Task<List<Product>> GetCategoriesWithPost(SearchCategoryOptions searchCategory);
    }
}
