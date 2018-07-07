using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public class SalesReason : EntityBase
	{
		public int SalesReasonId { get; set; }
		public string Name { get; set; }
		public string ReasonType { get; set; }

		public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; } = new HashSet<SalesOrderHeaderSalesReason>();
	}
}
