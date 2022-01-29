using ProductionManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManager.Domain.Entities
{
    public class MachineTool : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
