using ProductionManager.Domain.Common;

namespace ProductionManager.Domain.Entities
{
    public class ProductPrice : AuditableEntity
    {
        public int PriceId { get; set; }
        public decimal Price { get; set; }
    }
}