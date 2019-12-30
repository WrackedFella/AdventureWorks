using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class ProductReview : EntityBase
    {
	    [Key]
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
