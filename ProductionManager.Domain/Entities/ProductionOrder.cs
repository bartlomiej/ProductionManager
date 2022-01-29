using ProductionManager.Domain.Common;
using System;
using System.Collections.Generic;

namespace ProductionManager.Domain.Entities
{
    public class ProductionOrder : AuditableEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public decimal Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int TechnologicalProcessId { get; set; }
        public TechnologicalProcess TechnologicalProcess { get; set; }
        public DateTime DateOfAdd { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfStop { get; set; }
        public IEnumerable<ProductionOrderRealization> Realization { get; set; }
    }
}
