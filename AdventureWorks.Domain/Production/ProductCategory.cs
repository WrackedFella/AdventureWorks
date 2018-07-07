using System;
using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class ProductCategory : EntityBase
	{
		public int ProductCategoryId { get; set; }
		public string Name { get; set; }
		public Guid Rowguid { get; set; }

		public virtual ICollection<ProductSubcategory> ProductSubcategory { get; set; } = new HashSet<ProductSubcategory>();
	}
}
