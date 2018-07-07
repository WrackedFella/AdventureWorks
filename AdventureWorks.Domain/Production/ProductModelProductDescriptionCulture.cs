using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class ProductModelProductDescriptionCulture : EntityBase
	{
		public int ProductModelId { get; set; }
		public int ProductDescriptionId { get; set; }
		public string CultureId { get; set; }

		public virtual Culture Culture { get; set; }
		public virtual ProductDescription ProductDescription { get; set; }
		public virtual ProductModel ProductModel { get; set; }
	}
}
