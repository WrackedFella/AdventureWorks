using System.Collections.Generic;
using AdventureWorks.Core;
using AdventureWorks.Domain.Person;

namespace AdventureWorks.Domain.Purchasing
{
	public class Vendor : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public string AccountNumber { get; set; }
		public string Name { get; set; }
		public byte CreditRating { get; set; }
		public bool? PreferredVendorStatus { get; set; }
		public bool? ActiveFlag { get; set; }
		public string PurchasingWebServiceUrl { get; set; }

		public virtual BusinessEntity BusinessEntity { get; set; }
		public virtual ICollection<ProductVendor> ProductVendor { get; set; } = new HashSet<ProductVendor>();
		public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; } = new HashSet<PurchaseOrderHeader>();
	}
}
