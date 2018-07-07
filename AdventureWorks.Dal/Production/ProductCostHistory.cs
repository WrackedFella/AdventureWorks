using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.Production
{
	public class ProductCostHistory : EntityBase
	{
		public int ProductId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public decimal StandardCost { get; set; }

		public virtual Product Product { get; set; }
	}
}
