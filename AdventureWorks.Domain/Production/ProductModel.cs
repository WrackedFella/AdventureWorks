using System;
using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class ProductModel : EntityBase
	{
		public int ProductModelId { get; set; }
		public string Name { get; set; }
		public string CatalogDescription { get; set; }
		public string Instructions { get; set; }
		public Guid Rowguid { get; set; }

		public virtual ICollection<Product> Product { get; set; } = new HashSet<Product>();
		public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; } = new HashSet<ProductModelIllustration>();
		public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; } = new HashSet<ProductModelProductDescriptionCulture>();
	}
}
