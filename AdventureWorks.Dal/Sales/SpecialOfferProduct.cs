using AdventureWorks.Dal.Production;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public partial class SpecialOfferProduct
	{
		public int SpecialOfferId { get; set; }
		public int ProductId { get; set; }
		public Guid Rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual Product Product { get; set; }
		public virtual SpecialOffer SpecialOffer { get; set; }
		public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; } = new HashSet<SalesOrderDetail>();
	}
}
