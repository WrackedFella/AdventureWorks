﻿using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.Production
{
	public class TransactionHistory : EntityBase
	{
		public int TransactionId { get; set; }
		public int ProductId { get; set; }
		public int ReferenceOrderId { get; set; }
		public int ReferenceOrderLineId { get; set; }
		public DateTime TransactionDate { get; set; }
		public string TransactionType { get; set; }
		public int Quantity { get; set; }
		public decimal ActualCost { get; set; }

		public virtual Product Product { get; set; }
	}
}