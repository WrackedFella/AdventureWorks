using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Production
{
    public class ProductSubcategory : EntityBase
    {
        [Key]
        public int ProductSubcategoryId { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ICollection<Product> Product { get; set; } = new HashSet<Product>();
    }
}
