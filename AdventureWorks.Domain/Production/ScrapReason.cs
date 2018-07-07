using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class ScrapReason : EntityBase
	{
		public short ScrapReasonId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<WorkOrder> WorkOrder { get; set; } = new HashSet<WorkOrder>();
	}
}
