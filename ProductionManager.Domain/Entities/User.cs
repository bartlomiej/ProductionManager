using ProductionManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionManager.Domain.Entities
{
    internal class User : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
