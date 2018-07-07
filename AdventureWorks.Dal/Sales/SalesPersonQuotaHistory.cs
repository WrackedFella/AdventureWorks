using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.Sales
{
	public class SalesPersonQuotaHistory : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public DateTime QuotaDate { get; set; }
		public decimal SalesQuota { get; set; }
		public Guid Rowguid { get; set; }

		public virtual SalesPerson BusinessEntity { get; set; }
	}
}
