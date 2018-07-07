using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class TransactionHistoryArchive : EntityBase
	{
		public int TransactionId { get; set; }
		public int ProductId { get; set; }
		public int ReferenceOrderId { get; set; }
		public int ReferenceOrderLineId { get; set; }
		public DateTime TransactionDate { get; set; }
		public string TransactionType { get; set; }
		public int Quantity { get; set; }
		public decimal ActualCost { get; set; }
	}
}
