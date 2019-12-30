using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class ProductCostHistory : EntityBase
    {
	    [Key]
        public int ProductId { get; set; }
        [Key]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal StandardCost { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
