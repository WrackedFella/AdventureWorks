using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Production
{
    public class Illustration : EntityBase
    {
	    [Key]
        public int IllustrationId { get; set; }
        public string Diagram { get; set; }

        public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; } = new HashSet<ProductModelIllustration>();
    }
}
