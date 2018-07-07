using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public class Location : EntityBase
	{
		public short LocationId { get; set; }
		public string Name { get; set; }
		public decimal CostRate { get; set; }
		public decimal Availability { get; set; }

		public virtual ICollection<ProductInventory> ProductInventory { get; set; } = new HashSet<ProductInventory>();
		public virtual ICollection<WorkOrderRouting> WorkOrderRouting { get; set; } = new HashSet<WorkOrderRouting>();
	}
}
