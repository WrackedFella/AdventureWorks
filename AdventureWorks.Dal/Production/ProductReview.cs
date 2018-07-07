using AdventureWorks.Core;
using System;

namespace AdventureWorks.Dal.Production
{
	public class ProductReview : EntityBase
	{
		public int ProductReviewId { get; set; }
		public int ProductId { get; set; }
		public string ReviewerName { get; set; }
		public DateTime ReviewDate { get; set; }
		public string EmailAddress { get; set; }
		public int Rating { get; set; }
		public string Comments { get; set; }

		public virtual Product Product { get; set; }
	}
}
