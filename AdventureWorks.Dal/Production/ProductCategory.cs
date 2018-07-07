using AdventureWorks.Core;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public class ProductCategory : EntityBase
	{
		public int ProductCategoryId { get; set; }
		public string Name { get; set; }
		public Guid Rowguid { get; set; }

		public virtual ICollection<ProductSubcategory> ProductSubcategory { get; set; } = new HashSet<ProductSubcategory>();
	}
}
