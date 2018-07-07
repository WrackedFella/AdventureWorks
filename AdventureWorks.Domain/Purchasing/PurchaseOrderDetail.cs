using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;
using AdventureWorks.Domain.Production;

namespace AdventureWorks.Domain.Purchasing
{
	public class PurchaseOrderDetail : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PurchaseOrderDetailId
		{
			get => this.Id;
			set => this.Id = value;
		}
		public int PurchaseOrderId { get; set; }
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
