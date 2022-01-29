using ProductionManager.Domain.Common;

namespace ProductionManager.Domain.Entities
{
    public  class Product : AuditableEntity
    {
        public int ProductId { get; set; }
        public string Index { get; set; }
        public string Nazwa { get; set; }
        public short Wariant { get; set; }

        public int PriceId { get; set; }
        public ProductPrice Price { get; set; }
    }
}
