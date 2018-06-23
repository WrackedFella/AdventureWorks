using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public partial class ProductSubcategory
	{
		public int ProductSubcategoryId { get; set; }
		public int ProductCategoryId { get; set; }
		public string Name { get; set; }
		public Guid Rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual ProductCategory ProductCategory { get; set; }
		public virtual ICollection<Product> Product { get; set; } = new HashSet<Product>();
	}
}
