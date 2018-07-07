using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public class ScrapReason : EntityBase
	{
		public short ScrapReasonId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<WorkOrder> WorkOrder { get; set; } = new HashSet<WorkOrder>();
	}
}
