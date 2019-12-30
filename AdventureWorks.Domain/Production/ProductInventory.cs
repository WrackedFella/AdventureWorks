using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class ProductInventory : EntityBase
    {
	    [Key]
        public int ProductId { get; set; }
        [Key]
        public short LocationId { get; set; }
        public string Shelf { get; set; }
        public byte Bin { get; set; }
        public short Quantity { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
