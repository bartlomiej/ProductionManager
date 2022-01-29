using ProductionManager.Domain.Common;

namespace ProductionManager.Domain.Entities
{
    public class Operation : AuditableEntity
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        public bool Warehouse { get; set; }
        public bool QualityControl { get; set; }
        public bool Interoperative { get; set; }
        public bool ReleaseOfMaterial { get; set; }

    }
}