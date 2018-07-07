using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
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
