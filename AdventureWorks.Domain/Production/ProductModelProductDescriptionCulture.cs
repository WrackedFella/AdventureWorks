using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Production
{
    public class ProductModelProductDescriptionCulture : EntityBase
    {
	    [Key]
        public int ProductModelId { get; set; }
        [Key]
        public int ProductDescriptionId { get; set; }
        [Key]
        public string CultureId { get; set; }

        public virtual Culture Culture { get; set; }
        public virtual ProductDescription ProductDescription { get; set; }
        public virtual ProductModel ProductModel { get; set; }
    }
}
