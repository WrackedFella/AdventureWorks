using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Production
{
    public class ProductProductPhoto : EntityBase
    {
	    [Key]
        public int ProductId { get; set; }
        [Key]
        public int ProductPhotoId { get; set; }
        public bool Primary { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductPhoto ProductPhoto { get; set; }
    }
}
