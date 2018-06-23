﻿using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public partial class SalesReason
	{
		public int SalesReasonId { get; set; }
		public string Name { get; set; }
		public string ReasonType { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; } = new HashSet<SalesOrderHeaderSalesReason>();
	}
}
