using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManager.Application.Functions.Products
{
    public class GetProductsListQuery : IRequest<List<ProductViewModel>>
    {
        public int ProductId { get; set; }
        public string Index { get; set; }
        public string Nazwa { get; set; }
        public short Wariant { get; set; }
    }
}
