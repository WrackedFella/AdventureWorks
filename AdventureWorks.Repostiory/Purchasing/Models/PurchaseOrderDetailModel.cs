using System;
using System.Collections.Generic;
using System.Text;
using AdventureWorks.Core;

namespace AdventureWorks.Repository.Purchasing.Models
{
	public class PurchaseOrderDetailModel : ModelBase
	{
		public int PurchaseOrderDetailId
		{
			get => this.Id;
			set => this.Id = value;
		}

		public DateTime DueDate { get; set; }
		public short OrderQty { get; set; }
		public int ProductId { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal LineTotal { get; set; }
		public decimal ReceivedQty { get; set; }
		public decimal RejectedQty { get; set; }
		public decimal StockedQty { get; set; }

		public string ProductDisplayName { get; set; }
	}
}
