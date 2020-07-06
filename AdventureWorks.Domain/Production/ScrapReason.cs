using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Production
{
    public class ScrapReason : EntityBase
    {
	    [Key]
        public short ScrapReasonId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WorkOrder> WorkOrder { get; set; } = new HashSet<WorkOrder>();
    }
}
