using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.Production
{
	public class ProductListPriceHistory : EntityBase
	{
		public int ProductId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public decimal ListPrice { get; set; }

		public virtual Product Product { get; set; }
	}
}
