using ProductionManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManager.Domain.Entities
{
    public class TechnologicalProcess : AuditableEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int VersionId { get; set; }
        public TechnologicalProcessVersion Version { get; set; }
        public short Subversion { get; set; }
        public string Uwagi { get; set; }
    }
}
