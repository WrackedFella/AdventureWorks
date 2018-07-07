using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class Culture : EntityBase
	{
		public string CultureId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; } = new HashSet<ProductModelProductDescriptionCulture>();
	}
}
