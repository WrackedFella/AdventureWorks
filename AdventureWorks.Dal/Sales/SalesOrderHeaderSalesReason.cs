using AdventureWorks.Core;

namespace AdventureWorks.Dal.Sales
{
	public class SalesOrderHeaderSalesReason : EntityBase
	{
		public int SalesOrderId { get; set; }
		public int SalesReasonId { get; set; }

		public virtual SalesOrderHeader SalesOrder { get; set; }
		public virtual SalesReason SalesReason { get; set; }
	}
}
