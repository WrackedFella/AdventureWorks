using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Sales
{
	public class SalesReason : EntityBase
	{
		public int SalesReasonId { get; set; }
		public string Name { get; set; }
		public string ReasonType { get; set; }

		public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; } = new HashSet<SalesOrderHeaderSalesReason>();
	}
}
