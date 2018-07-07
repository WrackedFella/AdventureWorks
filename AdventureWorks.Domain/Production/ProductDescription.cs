using System;
using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class ProductDescription : EntityBase
	{
		public int ProductDescriptionId { get; set; }
		public string Description { get; set; }
		public Guid Rowguid { get; set; }

		public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; } = new HashSet<ProductModelProductDescriptionCulture>();
	}
}
