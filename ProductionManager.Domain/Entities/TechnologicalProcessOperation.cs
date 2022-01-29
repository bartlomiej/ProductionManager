using ProductionManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManager.Domain.Entities
{
    public class TechnologicalProcessOperation : AuditableEntity
    {
        public int Id { get; set; }
        public int ProcessId { get; set; }
        public int OperationId { get; set; }
        public Operation Operation { get; set; }
        public int SetUpTime { get; set; }
        public int UnitTime { get; set; }
    }
}
