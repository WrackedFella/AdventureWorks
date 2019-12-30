using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class ProductCategory : EntityBase
    {
	    [Key]
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<ProductSubcategory> ProductSubcategory { get; set; } = new HashSet<ProductSubcategory>();
    }
}
