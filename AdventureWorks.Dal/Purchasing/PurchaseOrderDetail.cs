using AdventureWorks.Core;
using AdventureWorks.Dal.Production;
using System;

namespace AdventureWorks.Dal.Purchasing
{
	public class PurchaseOrderDetail : EntityBase
	{
		public int PurchaseOrderId { get; set; }
		public int PurchaseOrderDetailId { get; set; }
		public DateTime DueDate { get; set; }
		public short OrderQty { get; set; }
		public int ProductId { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal LineTotal { get; set; }
		public decimal ReceivedQty { get; set; }
		public decimal RejectedQty { get; set; }
		public decimal StockedQty { get; set; }

		public virtual Product Product { get; set; }
		public virtual PurchaseOrderHeader PurchaseOrder { get; set; }
	}
}
