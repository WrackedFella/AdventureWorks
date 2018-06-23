using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public partial class ProductDescription
	{
		public int ProductDescriptionId { get; set; }
		public string Description { get; set; }
		public Guid Rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; } = new HashSet<ProductModelProductDescriptionCulture>();
	}
}
