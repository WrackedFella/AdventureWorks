using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Production
{
	public class Illustration : EntityBase
	{
		public int IllustrationId { get; set; }
		public string Diagram { get; set; }

		public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; } = new HashSet<ProductModelIllustration>();
	}
}
