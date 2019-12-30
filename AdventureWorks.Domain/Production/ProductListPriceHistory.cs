using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class ProductListPriceHistory : EntityBase
    {
	    [Key]
        public int ProductId { get; set; }
        [Key]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal ListPrice { get; set; }

        public virtual Product Product { get; set; }
    }
}
