using ProductionManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManager.Domain.Entities
{
    public class TechnologicalProcessVersion : AuditableEntity
    {
        public int Id { get; set; }
        public string VersionName { get; set; }
    }
}
