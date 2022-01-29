using AutoMapper;
using MediatR;
using ProductionManager.Application.Contracts.Persistence;
using ProductionManager.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductionManager.Application.Functions.Products
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, List<ProductViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Product> _productRepository;

        public GetProductsListQueryHandler(IMapper mapper, IAsyncRepository<Product> productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public async Task<List<ProductViewModel>> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var all = await _productRepository.GetAllAsync();
            var allordered = all.OrderBy(x => x.Index);

            return _mapper.Map<List<ProductViewModel>>(allordered);
        }
    }
}
