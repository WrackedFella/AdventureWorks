using AdventureWorks.Core;

namespace AdventureWorks.Dal.Production
{
	public class ProductModelIllustration : EntityBase
	{
		public int ProductModelId { get; set; }
		public int IllustrationId { get; set; }

		public virtual Illustration Illustration { get; set; }
		public virtual ProductModel ProductModel { get; set; }
	}
}
