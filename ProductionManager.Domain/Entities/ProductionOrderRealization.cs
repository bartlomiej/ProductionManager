using ProductionManager.Domain.Common;
using System;

namespace ProductionManager.Domain.Entities
{
    public class ProductionOrderRealization : AuditableEntity
    {
        public int Id { get; set; }
        public int ProductionOrderId { get; set; }
        public ProductionOrder ProductionOrder { get; set; }
        public int TechnologicalProcessOperationId { get; set; }
        public TechnologicalProcessOperation TechnologicalProcessOperation { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int MachineToolId { get; set; }
        public MachineTool MachineTool { get; set; }
        public DateTime RealizationDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public decimal GoodQuantity { get; set; }
        public decimal BadQuantity { get; set; }
        public bool Finished { get; set; }
        public bool IncludeSetUpTime { get; set; }
    }
}